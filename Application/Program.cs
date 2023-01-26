//namespace Application
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{
//			System.Console.WriteLine("Hello, World!");
//		}
//	}
//}

//namespace Application;

//internal class Program
//{
//	static void Main(string[] args)
//	{
//		System.Console.WriteLine("Hello, World!");
//	}
//}

namespace Application;

internal class Program
{
	static void Main(string[] args)
	{
		// **************************************************
		//int x;
		//x = 10;

		//string s;
		//s = "Ali";

		////var y; // Compile Error!

		//var y = 10;

		////var t; // Compile Error!

		//var t = "Ali";
		// **************************************************



		// **************************************************
		Person person1 = new Person();

		person1.Age = 20;
		person1.FullName = "Ali Reza Alavi";
		// **************************************************

		// **************************************************
		Person person2 = new();

		person2.Age = 20;
		person2.FullName = "Ali Reza Alavi";
		// **************************************************

		// **************************************************
		var person3 = new Person();

		person3.Age = 20;
		person3.FullName = "Ali Reza Alavi";
		// **************************************************

		// **************************************************
		var person4 = new Person() { FullName = "Ali Reza Alavi", Age = 20 };
		// **************************************************

		// **************************************************
		var person5 =
			new Person()
			{
				FullName = "Ali Reza Alavi",
				Age = 20
			};
		// **************************************************

		// **************************************************
		var person6 =
			new Person
			{
				FullName = "Ali Reza Alavi",
				Age = 20
			};
		// **************************************************

		// **************************************************
		var person7 =
			new Person
			{
				FullName = "Ali Reza Alavi",
				Age = 20,
			};
		// **************************************************

		// **************************************************
		var person8 =
			new Person
			{
				Age = 20,
				FullName = "Ali Reza Alavi",
			};
		// **************************************************

		// **************************************************
		var circle =
			new Circle(x: 5, y: 10, radius: 20)
			{
				BorderWidth = 2,
				BorderColor = 200,
			};
		// **************************************************
	}
}
