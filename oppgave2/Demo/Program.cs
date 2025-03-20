namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Fjern kommentar på metode-kall. Hva blir resultatet?
            PrintTypes();
            PrintIncrementNumber();
            PrintExtendedText();
            PrintExtendedTextObject();
            PrintIncrementNumberWithOutParam();
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
            p.Name = "Reodor";
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
            obj.Name = obj.Name + " Felgen";
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