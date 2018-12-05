using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public partial class Person
	{
		partial void DoSomethingElse();

		public void DoSomething()
		{
			Console.WriteLine("Начало первого класса");
			DoSomethingElse();
			Console.WriteLine("Конец первого класса");
		}
	}
}
