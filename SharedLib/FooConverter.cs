using System;
using System.Reflection;
using Newtonsoft.Json;

namespace SharedLib
{
	public class FooConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue("foo");
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return new Foo();
		}

		public override bool CanConvert(Type objectType)
		{
			return typeof(IFoo).GetTypeInfo().IsAssignableFrom(objectType);
		}
	}
}
