# C# .NET - Grunnleggende programmering

## Mål
Bli kjent med typer i C#

## Tipp resultatet...

```
namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Fjern kommentar på metode-kall. Hva blir resultatet?
            //PrintTypes();
            //PrintIncrementNumber();
            //PrintExtendedText();
            //PrintExtendedTextObject();
            //PrintIncrementNumberWithOutParam();
        }

        /// <summary>
        /// Hva blir resultatet av denne kjøringen?
        /// </summary>
        public static void PrintTypes()
        {
            Console.WriteLine(typeof(string).IsPrimitive);
            Console.WriteLine(typeof(int).IsPrimitive);
            Console.WriteLine(typeof(double).IsPrimitive);
        }

        /// <summary>
        /// Hva blir resultatet av denne kjøringen?
        /// </summary>
        public static void PrintIncrementNumber()
        {
            var a = 3;
            Console.WriteLine(a);
            IncrementNumber(a);
            Console.WriteLine(a);
        }

        /// <summary>
        /// Hva blir resultatet av denne kjøringen?
        /// </summary>
        public static void PrintExtendedText()
        {
            var a = "Her er en tekst";
            Console.WriteLine(a);
            ExtendText(a);
            Console.WriteLine(a);
        }

        /// <summary>
        /// Hva blir resultatet av denne kjøringen?
        /// </summary>
        public static void PrintExtendedTextObject()
        {
            Person p = new Person();
            p.Name = "Reidar";
            Console.WriteLine(p.Name);
            ExtendText(p);
            Console.WriteLine(p.Name);
        }

        /// <summary>
        /// Hva blir resultatet av denne kjøringen?
        /// </summary>
        public static void PrintIncrementNumberWithOutParam()
        {
            int a = 3;
            Console.WriteLine(a);
            IncrementNumberOutVar(out a);
            Console.WriteLine(a);
        }

        /// <summary>
        /// Inkrement et tall
        /// </summary>
        /// <param name="number"></param>
        public static void IncrementNumber(int number)
        {
            number++;
        }

        /// <summary>
        /// Utvid tekst
        /// </summary>
        /// <param name="txt"></param>
        public static void ExtendText(string txt)
        {
            txt = txt + "...";
        }

        /// <summary>
        /// Utvid tekst for et objekt
        /// </summary>
        /// <param name="obj"></param>
        public static void ExtendText(Person obj)
        {
            obj.Name = obj.Name + " Liabø";
        }

        /// <summary>
        /// Inkrement et tall med en ut-parameter
        /// </summary>
        /// <param name="number"></param>
        public static void IncrementNumberOutVar(out int number)
        {
            number = 5;
        }
    }

    public class Person
    {
        public string Name { get; set; } = "";
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
