using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace MyApp
{
    internal class Program
    {
        /// <summary>
        /// Example for Nullable Variables
        /// </summary>
        static void NullableAreYouMajorExample()
        {
            //Console.WriteLine("Welcome to C# Training");
            //string UserName = Console.ReadLine();
            //Console.WriteLine("Hello {0}", UserName);

            //double i = 233.2224567;
            //Console.WriteLine(i);

            bool? AreYouMajor = null;
            if(AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            } else if(AreYouMajor == false)
            {
                Console.WriteLine("User is Not Major");
            } else
            {
                Console.WriteLine("User have not Answered!");
            }
        }

        /// <summary>
        /// Example:2 for Nullable Coalescing of Variables
        /// </summary>
        static void NullableTicketsExampleTwo()
        {
            int? TicketsOnSale = null;

            int AvailableTickets = 0;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            // Instead Above Lines, Use Below 1 line:
            AvailableTickets = TicketsOnSale ?? 0;  // 0 is the default value if TicketsOnSale=NULL
            Console.WriteLine("Available Tickets: {0}", AvailableTickets);
        }

        /// <summary>
        /// Used for explaining difference between "Instance" and "Static" methods
        /// </summary>
        public void CheckingInstanceMethods()
        {
            Console.WriteLine("This is printing from Instance Method");
        }

        /// <summary>
        /// "ref" keyword example 
        /// </summary>
        public static void RefKeywordsCalledFunction(ref int j)
        {
            j = 101;
        }
        public static void RefKeywordExample()
        {
            int i = 0;
            RefKeywordsCalledFunction(ref i); // if not "ref" prints "0"
            Console.WriteLine(i);
        }

        /// <summary>
        ///  "out" keyword example.
        ///  it is used when we don't want to have return value.
        /// </summary>
        public static void OutHelperFunctionCalculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
        public static void OutKeywordExample()
        {
            int FN = 5;
            int SN = 5;
            OutHelperFunctionCalculate(FN, SN, out int Sum, out int Product);
            Console.WriteLine("Sum is {0} and Product is {1}",Sum, Product);
        }

        /// <summary>
        /// Parametrize Example: using of "params" keyword
        /// it is used when we want to make parameters: optional
        /// </summary>
        public static void ParamsExample(params int[] Numbers)
        {
            Console.WriteLine("We have {0} elements in the Array", Numbers.Length);
            foreach (int i in Numbers) Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //NullableAreYouMajorExample();

            //NullableTicketsExampleTwo();

            //Program p = new Program();
            //p.CheckingInstanceMethods();

            //RefKeywordExample();

            //OutKeywordExample();

            //int[] Numbers = { 1, 2, 3, };
            //ParamsExample();
            //ParamsExample(Numbers);
            //ParamsExample(1, 2, 3, 4, 5, 6, 7, 8);


            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}
