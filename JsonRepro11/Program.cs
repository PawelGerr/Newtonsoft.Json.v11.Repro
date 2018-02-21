using System;
using Moq;
using Newtonsoft.Json;
using SharedLib;

namespace JsonRepro11
{
	class Program
	{
		static void Main(string[] args)
		{
			var mock = new Mock<IFoo>();
			IFoo foo = mock.Object;

			var json = JsonConvert.SerializeObject(foo, new JsonSerializerSettings() { Converters = { new FooConverter() } });
			Console.WriteLine(json);
		}
	}
}
