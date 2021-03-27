using System;

namespace DesignPatternFactory
{
	public class Program
	{
		public enum PersonType
		{
			Rural,
			Urban
		}

		static void Main(string[] args)
		{
			IPerson person1 = new Factory().GetPerson(PersonType.Rural);
			IPerson person2 = new Factory().GetPerson(PersonType.Urban);
			Console.WriteLine("Hello World!");
		}
	}
}
