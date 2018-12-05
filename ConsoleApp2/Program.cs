using System;



namespace ConsoleApp2
{

	class Program
	{
		//ref
		static void AdditionRef(ref int x, int y)
		{
			x = x + y;
			Console.WriteLine($"AdditionRef x = {x}");
		}

		//out
		static void AdditionOut(int x, int y, out int p, out int s)
		{
			p = (x + y) * 2;
			s = x * y;
			Console.WriteLine($"AdditionOut   p - {p}, s  - {s}");
		}






		static void Main(string[] args)
		{

			//Вызываем конструктор
			//Class1 ob = new Class1(5);
			//Console.WriteLine(ob.age);
			//Вызываем закрытый конструктор
			//Class1.minimumAge = 20;
			//Console.WriteLine(Class1.minimumAge);
			//Вызываем статистический конструктор
			//Console.WriteLine(Class1.minimumAge);
			//Вызываем поле для чтения и const
			//Class1 ob = new Class1(5);
			//int c1 = Class1.C;
			//Console.WriteLine(ob.p + c1);

			//ref
			//int x = 5;
			//AdditionRef(ref x, 7);

			//out
			//int p;
			//int s;
			//AdditionOut(2, 3, out p, out s);

			//partial
			//Person tom = new Person();
			//tom.DoSomething();

			//счетчик созанных объектов
			Over c1 = new Over();
			Over c2 = new Over();
			Over c3 = new Over();
			Console.WriteLine(Over.count);


			//get..set
			//Info[] inf = new Info[4];
			//for(int i = 0; i  < inf.Length; i++)
			//{
			//	inf[i] = new Info();
			//	inf[i].Name = Console.ReadLine();
			//	Console.WriteLine(inf[i].Name);
			//}


			//ID и поле для чтения. Переопределение методов объекта.
			ID id1 = new ID { Name = "Tom" };
			Console.WriteLine(id1.GetHashCode());
			ID id2 = new ID { Name = "Billy" };
			Console.WriteLine(id2.GetHashCode());
			ID id3 = new ID { Name = "Tom" };
			Console.WriteLine(id3.GetHashCode());
			Console.WriteLine(id3.Equals(id3));
			Console.WriteLine(id3.ToString());

			//Переопределение методов объекта




			//2
			Console.WriteLine("Введите число");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите число месяца");
			int m = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите год");
			int y = Convert.ToInt32(Console.ReadLine());
			Data data = new Data(c,m,y);

			//
			Console.WriteLine("Введите количество дат которые будут проверены: ");
			int col = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Программа дат. Вам следует ввести {col} дат: ");
			Data[] dates = new Data[col];
			for(int i = 0; i < dates.Length; i++)
			{	
				Console.WriteLine("Введите число");
				c = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите число месяца");
				m = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите год");
				y = Convert.ToInt32(Console.ReadLine());
				dates[i] = new Data(c,m,y );
			}


			Console.ReadLine();
		}

	}

	public class Class1
	{

		public string last, first;
		public int age;
		public static int minimumAge;
		//Определяем const
		public const int C = 10;

		public Class1(string lastName, string firstName)
		{

			last = lastName;
			first = firstName;
		}
		public Class1(string c)
		{
			c = " номер 1 ";
			last = "Это строка" + c;
		}
		public Class1(int age1)
		{
			age = age1 - 2;
		}

		//Статический конструктор
		static Class1()
		{
			minimumAge = 18;
			Console.WriteLine(minimumAge + " вызван статический конструктор");
		}


		//Закрытый конструктор
		//private Class1 () { }



	}
	//счетчик созданных объектов
	public class Over
	{
		public static int count = 0;
		public Over()
		{
			count++;
		}
	}

	//get..set
	class Info
	{
		private string name;

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				if (value.IndexOf("") >= 0)
					name = "No name";
				else
					name = value;
			}
		}
	}
	//Поле  для чтения и использование ID. Переопределение методов объекта
	class ID
	{
		//Поле для чтения
		//public readonly int x = 5;

		public string Name { get; set; }
		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			if(obj.GetType() != this.GetType())
				return false;

			ID id = (ID)obj;
			return this.Name == id.Name;
		}
		public override string ToString()
		{
			return Name.ToString();
		}
	}


	//2

	class Data
	{
		DateTime dt;
		public int chislo { get; set; }
		public int mesyac { get; set; }
		public int god { get; set; }

		public Data(int d, int m, int y)
		{
			bool parse = DateTime.TryParse($"{d}.{m}.{y}", out dt);
			if (parse)
			{
				Console.WriteLine($"Веденная дата {d}.{m}.{y} существует");
			} else
				Console.WriteLine($"Введенная дата {d}.{m}.{y} не найдена");
		}
	}
}
