namespace enumsAct2
{
    internal class Program
    {
        enum calculator
        {add =1,
         subtract,multiply,divide,exit,

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an enum option: ");

            foreach (calculator cal in Enum.GetValues(typeof(calculator)))
            {
                Console.WriteLine($"To choose {cal.ToString()}, Press {(int)cal}");
            }
            //going to be used to pick the number that the user is going to input for the calculator. 
            int pick =Convert.ToInt32(Console.ReadLine());
            double numb1, numb2;
            Console.WriteLine("Enter the first number: ");
            numb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            numb2 = double.Parse(Console.ReadLine());

            switch (pick)
            {
                case 1:
                    Displayresults(numb1, numb2, add(numb1, numb2));
                    break;

                case 2:
                    Displayresults(numb1, numb2, subtract(numb1, numb2));
                    break;
                case 3:
                    Displayresults(numb1, numb2, multiply(numb1, numb2));
                    break;

                case 4:
                    Displayresults(numb1, numb2, divide(numb1, numb2));
                    break;

                default: Console.WriteLine("Please select the right option from the menu ");
                    break;
            }

            Console.ReadKey();
        }
        static double add(double a, double b)
        {
            return a + b;
        }
        static double subtract(double a, double b)
        {
            return a - b;
        }
        static double multiply(double a, double b)
        {
            return a * b;
        }
        static double divide(double a, double b)
        {
            return a / b;
        }

        static void Displayresults(double a, double b, double results)
        {
            Console.WriteLine($"The results of {a} and {b} is {results}");
        }
    }
    

}
