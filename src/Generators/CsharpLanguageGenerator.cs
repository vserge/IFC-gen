using Express;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFC4.Generators
{
    public class CsharpLanguageGenerator : ILanguageGenerator{

		public string Begin(){
			return
			@"/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
	
namespace IFC4
{
	public abstract class BaseIfc
	{
		[JsonProperty(""id"")]
		public Guid Id{get;}

		public BaseIfc()
		{
			Id = Guid.NewGuid();
		}

		public virtual string ToJSON()
		{
			var settings = new JsonSerializerSettings()
			{
				Formatting = Formatting.Indented,
				TypeNameHandling = TypeNameHandling.Objects
			};
			return JsonConvert.SerializeObject(this);
		}

		public virtual string ToSTEP()
		{
			throw new NotImplementedException();
		}
	}

	public abstract class Select : BaseIfc
	{
		[JsonProperty(""value"")]
		public dynamic Value {get;protected set;}
	}

	/// <summary>
	/// A type wrapper for IFC.
	/// </summary>
	public class IfcType<T> : BaseIfc
	{
		[JsonProperty(""value"")]
		public T Value{get;set;}
		public IfcType(T value)
		{
			Value = value;
		}

		public static implicit operator IfcType<T>(T value)
		{
			return new IfcType<T>(value);
		}
	}
	";
		}

		public string End(){
			return "}";
		}

        public string Assignment(AttributeData data){
            return $"\t\t\t{data.Name} = {data.ParameterName};\n";
        }

        public string Allocation(AttributeData data){
            if(data.IsCollection){
				return $"\t\t\t{data.Name} = new {data.Type}();\n";
			}
			return string.Empty;
        }

        public string AttributeDataType(AttributeData data){
            if(data.IsCollection)
            {
                return 	$"{string.Join("",Enumerable.Repeat("List<",data.Rank))}{data.type}{string.Join("",Enumerable.Repeat(">",data.Rank))}";
            }
            return data.type;
        }

        public string AttributeDataString(AttributeData data){
            var opt = data.IsOptional? "// optional":string.Empty;
			var prop = $"\t\tpublic {data.Type} {data.Name}{{get;set;}} {opt}\n";
			return prop;
        }

        private string WrappedType(SimpleType data){
            if(data.IsCollectionType)
            {
                return $"{string.Join("",Enumerable.Repeat("List<",data.Rank))}{data.wrappedType}{string.Join("",Enumerable.Repeat(">",data.Rank))}";
            }
            return data.wrappedType;
        }

        public string AsCollection(SimpleType data){
            return $"{string.Join("",Enumerable.Repeat("List<",data.Rank))}{WrappedType(data)}{string.Join("",Enumerable.Repeat(">",data.Rank))}";
        }

        public string SimpleTypeString(SimpleType data){
            var result = 
	$@"	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/{data.Name.ToLower()}.htm
	/// </summary>
	public class {data.Name} : IfcType<{WrappedType(data)}>
	{{
		public {data.Name}({WrappedType(data)} value):base(value){{}}	

		public static implicit operator {WrappedType(data)}({data.Name} v)
		{{
			return v.Value;
		}}

		public static implicit operator {data.Name}({WrappedType(data)} v)
		{{
			return new {data.Name}(v);
		}}	

		public static {data.Name} FromJSON(string json)
		{{
			return JsonConvert.DeserializeObject<{data.Name}>(json);
		}}
	}}
";
			return result;
        }

        public string EnumTypeString(EnumType data){
            var result = 
    $@"	/// <summary>
    /// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/{data.Name.ToLower()}.htm
    /// </summary>
    public enum {data.Name} {{{string.Join(",",data.Values)}}}
";
			return result;
        }

        public string SelectTypeString(SelectType data){
            var constructors = new StringBuilder();
			foreach(var value in data.Values)
			{
				constructors.AppendLine($"\t\tpublic {data.Name}({value} value):base(value){{}}");
			}
			var result = 
	$@"	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/{data.Name.ToLower()}.htm
	/// </summary>
	[TypeConverter(typeof(SelectConverter<{data.Name}>))]
	public class {data.Name} : IfcSelect<{string.Join(",",data.Values)}>
	{{
{constructors}
		public static {data.Name} FromJSON(string json)
		{{
			return JsonConvert.DeserializeObject<{data.Name}>(json);
		}}
	}}
";
			return result;
        }

        public string EntityConstructorParams(Entity data, bool includeOptional)
		{
			// Constructor parameters include the union of this type's attributes and all super type attributes.
			// A constructor parameter is created for every attribute which does not derive
			// from IFCRelationship.

			var parents = data.ParentsAndSelf().Reverse();
			var attrs = parents.SelectMany(p=>p.Attributes);

			if(!attrs.Any())
			{
				return string.Empty;
			}

			var validAttrs = includeOptional?AttributesWithOptional(attrs):AttributesWithoutOptional(attrs);

			return string.Join(",", validAttrs.Select(a=>$"{a.Type} {a.ParameterName}"));
		}

        public string EntityBaseConstructorParams(Entity data, bool includeOptional){
            // Base constructor parameters include the union of all super type attributes.
			var parents = data.Parents().Reverse();

			var attrs = parents.SelectMany(p=>p.Attributes);
						
			if(!attrs.Any())
			{
				return string.Empty;
			}

			var validAttrs = includeOptional?AttributesWithOptional(attrs):AttributesWithoutOptional(attrs);

			return string.Join(",", validAttrs.Select(a=>$"{a.ParameterName}"));
        }

        public string EntityString(Entity data){
            var super =  "BaseIfc";
			var newMod = string.Empty;
			if(data.Subs.Any())
			{
				super = data.Subs[0].Name;;
				newMod = "new";
			}

			var modifier = data.IsAbstract? "abstract":string.Empty;

			// Create two constructors, one which includes optional parameters and 
			// one which does not. We need to check whether any of the parent types
			// have optional attributes as well, to avoid the case where the current type
			// doesn't have optional parameters, but a base type does.
			string constructors;
			if(data.ParentsAndSelf().SelectMany(e=>e.Attributes.Where(a=>a.IsOptional)).Any())
			{
				constructors = $@"
		/// <summary>
		/// Construct a {data.Name} with all required attributes.
		/// </summary>
		public {data.Name}({ConstructorParams(data,false)}):base({BaseConstructorParams(data,false)})
		{{
{Allocations(data)}
{Assignments(data, false)}
		}}
		/// <summary>
		/// Construct a {data.Name} with required and optional attributes.
		/// </summary>
		[JsonConstructor]
		public {data.Name}({ConstructorParams(data,true)}):base({BaseConstructorParams(data,true)})
		{{
{Allocations(data)}
{Assignments(data, true)}
		}}";
			}
			else
			{
				constructors =$@"
		/// <summary>
		/// Construct a {data.Name} with all required attributes.
		/// </summary>
		[JsonConstructor]
		public {data.Name}({ConstructorParams(data,false)}):base({BaseConstructorParams(data,false)})
		{{
{Allocations(data)}
{Assignments(data, false)}
		}}";
			}

			var classStr =
$@"
	/// <summary>
	/// <see href=""http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/{data.Name.ToLower()}.htm""/>
	/// </summary>
	public {modifier} partial class {data.Name} : {super}
	{{{data.Properties()}{constructors}
		public static {newMod} {data.Name} FromJSON(string json)
		{{
			return JsonConvert.DeserializeObject<{data.Name}>(json);
		}}
	}}";
			return classStr;
        }

		public string FileName{
			get{return "IFC.g.cs";}
		}

		public string ParseType(ExpressParser.SimpleTypeContext context){
			var type = string.Empty;
				if(context.binaryType() != null)
				{
					type = "byte[]";
				}
				else if(context.booleanType() != null)
				{
					type = "bool";
				}
				else if(context.integerType() != null)
				{
					type = "int";
				}
				else if(context.logicalType() != null)
				{
					type = "bool?";
				}
				else if(context.numberType() != null)
				{
					type = "double";
				}
				else if(context.realType() != null)
				{
					type = "double";
				}
				else if(context.stringType() != null)
				{
					type = "string";
				}
			return type;
		}

		private  string Assignments(Entity entity, bool includeOptional)
		{
			var attrs = includeOptional?AttributesWithOptional(entity.Attributes):AttributesWithoutOptional(entity.Attributes);
			if(!attrs.Any())
			{
				return string.Empty;
			}

			var assignBuilder = new StringBuilder();
			foreach(var a in attrs)
			{
				var assign = Assignment(a);
				if(!string.IsNullOrEmpty(assign))
				{
					assignBuilder.Append(assign);
				}
			}
			return assignBuilder.ToString();
		}

		private string Allocations(Entity entity){

			var allocBuilder = new StringBuilder();
			foreach(var a in entity.Attributes.Where(a=>!a.IsDerived)){
				var alloc = Allocation(a);
				if(!string.IsNullOrEmpty(alloc)){
					allocBuilder.Append(alloc);
				}
			}
			return allocBuilder.ToString();
		}

		internal IEnumerable<AttributeData> AttributesWithOptional(IEnumerable<AttributeData> ad)
		{
			return  ad	.Where(a=>!a.IsInverse)
						.Where(a=>!a.IsDerived);
		}

		internal IEnumerable<AttributeData> AttributesWithoutOptional(IEnumerable<AttributeData> ad)
		{
			return  ad	.Where(a=>!a.IsInverse)
						.Where(a=>!a.IsDerived)
						.Where(a=>!a.IsOptional);
		}

				/// <summary>
		/// Return a set of constructor parameters in the form 'Type name1, Type name2'
		/// </summary>
		/// <returns></returns>
		private string ConstructorParams(Entity data, bool includeOptional)
		{
			return EntityConstructorParams(data, includeOptional);
		}
		
		/// <summary>
		/// Return a set of constructor params in the form `name1, name2`.
		/// </summary>
		/// <returns></returns>
		private string BaseConstructorParams(Entity data, bool includeOptional)
		{
			return EntityBaseConstructorParams(data, includeOptional);
		}
	}
}