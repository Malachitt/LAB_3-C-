using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public partial class Person
	{
		partial void DoSomethingElse()
		{
			Console.WriteLine("Содержимое второго класса");
		}
	}
}
