# C# .NET - Grunnleggende programmering

## Opprette, bygge,

Navigate to root folder

```
dotnet new console --framework net8.0 --use-program-main --name EmployeeRegister

(navigate to folder EmployeeRegister)

dotnet build -c Debug
dotnet test
dotnet run
dotnet clean

dotnet publish -c Release
```

Examine the files and folders that is created.
- EmployeeRegister.csproj -> This is the project file that should contain all the resources used to compile the application.
- bin -> Holds the binary files wich are executable
- obj -> Holds the intermediate files which are compiled, but not been linked
- Debug vs Release -> build configuration, with or without debugging symbols
- publish vs build -> publish -> packs the application and dependencies into a folder for deployment to a hosting system, when build only builds the project to binaries.

## Data types, variables and namespace

- C# is a strongly typed programming language

### Primitive types:
- Primitive types in C# are the most basic data types that are directly supported by the language and are predefined by the compiler.
- Examples of primitive types in C# include int, float, double, char, bool...
- Primitive types have a fixed size and are stored directly in memory, making them more efficient in terms of memory usage and performance.
- <b>NB! Primitive types are passed by value when used as method parameters, meaning a copy of the value is passed to the method.</b>
- Primitive types have default values, such as 0 for numeric types and false for boolean types, when not explicitly initialized.
- Operations on primitive types are generally faster than operations on non-primitive types due to their direct representation in memory.

### None-Primitive types:
- Non-primitive types in C# are more complex data types that are created by the programmer using primitive types or other non-primitive types.
- Examples of non-primitive types in C# include classes, structures, arrays, interfaces, delegates, and enumerations.
- Non-primitive types are used to represent more complex data structures and behaviors in C# programs.
- <b>NB! Non-primitive types are passed by reference when used as method parameters, meaning a reference to the original object is passed to the method.</b>
- Non-primitive types do not have a fixed size and are stored in the managed heap, allowing for dynamic memory allocation and deallocation.
- Non-primitive types can have methods, properties, and events associated with them, making them more versatile than primitive types.
- Non-primitive types can be used to model real-world entities, define custom data structures, and implement complex algorithms.
- Non-primitive types support inheritance, polymorphism, and encapsulation, enabling object-oriented programming principles in C#.
- string is a none primitive type, but is running in the CLI as a value type (struct data type). It can be NULL and is NULL as default value, but is passed as a value.

## Demo

```
namespace EmployeeRegister
{

  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(typeof(string).IsPrimitive);
      Console.WriteLine(typeof(int).IsPrimitive);
      Console.WriteLine(typeof(int).IsPrimitive);

      int a = 3;
      string b = "This is a demo ";
      StringObj c = new StringObj();
      c.Value = "This is a demo ";

      Console.WriteLine("Number before: " + a);
      IncrementNumber(a);
      Console.WriteLine("Number after: " + a);

      Console.WriteLine("Text before: " + b);
      ExtendText(b);
      Console.WriteLine("Text after: " + b);

      Console.WriteLine("Text before: " + c.Value);
      ExtendText(c);
      Console.WriteLine("Text after: " + c.Value);

      Console.WriteLine("Number before: " + a);
      IncrementNumberOutVar(out a);
      Console.WriteLine("Number after: " + a);
    }

    public static void IncrementNumber(int number)
    {
      number++;
    }

    public static void ExtendText(string txt)
    {
      txt = txt + "extended";
    }

    public static void ExtendText(StringObj obj)
    {
      obj.Value = obj.Value + "extended";
    }

    public static void IncrementNumberOutVar(out int number)
    {
      number = 5;
    }
  }

  public class StringObj
  {
    public string Value {get; set; }
  }
}

```


## Arrays:
- You declare an array by specifying the type of its elements. ex: int[]
- An array can be single-dimensional, multidimensional, or jagged (irregular array).
- All objects in C# is of type: object. Therefore we can create an array of object[] that can hold any type
- Array types are reference types derived from the abstract base type Array. All arrays implement IList and IEnumerable. You can use the foreach statement to iterate through an array.
- We are not going to use much time on arrays here. But just a short demo.
- Normally you will use collection objects as IList, ICollection, IEnumerable ....

```
namespace EmployeeRegister
{

  public class Program
  {
    public static void Main(string[] args)
    {
      int[] list = new int[3];
      list[0] = 3;
      list[1] = 4;
      list[2] = 5;

    // int[] list = [3, 4, 5];

      foreach(int i in list)
      {
        Console.Write(i);
      }

      Console.WriteLine();
      Console.WriteLine("-------------");

      int[][] jaggedArray = new int[3][];
      jaggedArray[0] = [1, 3, 5, 7, 9];
      jaggedArray[1] = [0, 2, 4, 6];
      jaggedArray[2] = [11, 22];

      // int[][] jaggedArray =
      // [
        // [1, 3, 5, 7, 9],
        // [0, 2, 4, 6],
        // [11, 22]
      // ];

      for(int i = 0; i<jaggedArray.Length; i++)
      {
        Console.Write(i + ":");
        foreach(int j in jaggedArray[i])
        {
          Console.Write(j);
        }

        Console.WriteLine();
      }

      string test = Console.ReadLine();
    }
  }
}

```

## Classes, methods and OOP:
- C# is an OOP language.
- Objects are dynamic (does not allocate specific size..).
- Objects is always by reference, a reference in memory to the heap.
- Objects defined as classes or structs.

```
namespace EmployeeRegister
{
	public class Program
	{
		public static void Main(string[] args)
		{
			person p = new person();
			p.firstname = "reodor";
			p.lastname = "felgen";
			p.birth = new datetime(1974, 9, 13);

			// Person p = new Person
			// {
			  // FirstName = "Reodor",
			  // LastName = "Felgen",
			  // Birth = new DateTime(1974, 9, 13)
			// };

			Console.WriteLine(p);

			string test = Console.ReadLine();
		}
	}
}
```

```
namespace EmployeeRegister
{
	public class Person
	{
	  public string FirstName { get; set; }
	  public string LastName { get; set; }
	  public DateTime? Birth { get; set; }

	  public override string ToString()
	  {
		  return FirstName + " " + LastName + ", Age: " + CalculateAge() ;
	  }

	  public int CalculateAge()
	  {
		if(!Birth.HasValue)
			return 0;

		DateTime now = DateTime.Now;

		int age = now.Year - Birth.Value.Year;

		if (now.Month < Birth.Value.Month || (now.Month == Birth.Value.Month && now.Day < Birth.Value.Day))
			age--;

		return age;
	  }
	}
}

```
