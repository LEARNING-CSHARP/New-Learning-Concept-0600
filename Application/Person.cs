//namespace Application
//{
//public class Person
//{
//	public int Age;
//	public string FullName;

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}



//public class Person
//{
//	/// <summary>
//	/// Default Constructor
//	/// Snippet => ctor
//	/// </summary>
//	public Person()
//	{
//	}

//	public int Age;
//	public string FullName;

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}



//public class Person
//{
//	public Person()
//	{
//	}

//	/// <summary>
//	/// این کار حرفه‌ای نیست
//	/// </summary>
//	public int Age = 20;

//	/// <summary>
//	/// این کار حرفه‌ای نیست
//	/// </summary>
//	public string FullName = "";

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}



//public class Person
//{
//	public Person()
//	{
//		Age = 20;

//		FullName = string.Empty;
//		//FullName = ""; // Null String
//	}

//	public int Age;
//	public string FullName;

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}



//public class Person
//{
//	public Person(string fullName)
//	{
//		FullName = fullName;
//	}

//	public int Age;
//	public string FullName;

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}



///// <summary>
///// نگاه ذیل دیگر عرف نیست
///// </summary>
//public class Person
//{
//	public Person()
//	{
//	}

//	public Person(int age)
//	{
//		Age = age;
//	}

//	public Person(string fullName)
//	{
//		FullName = fullName;
//	}

//	public Person(string fullName, int age)
//	{
//		Age = age;
//		FullName = fullName;
//	}

//	public int Age;
//	public int Weight;
//	public string FullName;
//	public string FatherName;

//	public void ShowInformation()
//	{
//		System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");
//	}
//}
//}

//namespace Application;

//public class Person
//{
//	public Person()
//	{
//		Age = 20;
//		FullName = string.Empty;
//	}

//	public int Age;

//	public string FullName;

//	public void ShowInformation()
//	{
//		//System.Console.WriteLine($"Full Name: {FullName}, Age: {Age}");

//		//System.Console.WriteLine(value: $"Full Name: {FullName}, Age: {Age}");

//		System.Console.WriteLine
//			(value: $"Full Name: {FullName}, Age: {Age}");
//	}
//}

namespace Application;

/// <summary>
/// کلاس شخص
/// </summary>
public class Person
{
	/// <summary>
	/// سازنده
	/// </summary>
	public Person()
	{
		Age = 20;
		FullName = string.Empty;
	}

	/// <summary>
	/// فیلد سن شخص
	/// </summary>
	public int Age;

	/// <summary>
	/// فیلد نام و نام خانوادگی شخص
	/// </summary>
	public string FullName;

	/// <summary>
	/// نمایش اطلاعات شخص
	/// </summary>
	public void ShowInformation()
	{
		System.Console.WriteLine
			(value: $"Full Name: {FullName}, Age: {Age}");
	}
}
