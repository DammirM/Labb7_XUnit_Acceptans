namespace Labb7_XUnit_Acceptans
{
    public class Program
    {
        static Math calculator = new Math();

        static bool run = true;

        static void Main(string[] args)
        {

            

            while (run)
            {
                Menu();
            }
            
                
        }

        static void Menu()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string operate = "";

            Console.Clear();
            Console.WriteLine("Calculator\n");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Divide");
            Console.WriteLine("4) Multiply");
            Console.WriteLine("5) Logg");
            Console.WriteLine("6) EXIT");
            string choice = Console.ReadLine();

            switch (choice)
            {


                case "1":
                    operate = "+";
                    Console.WriteLine(TextForNum1());
                    num1 = getNum();
                    Console.WriteLine(TextForNum2());
                    num2 = getNum();
                    result = calculator.Add(num1, num2);
                    Console.Write(SeeResult(result));
                    Console.ReadLine();
                    break;

                case "2":
                    operate = "-";
                    Console.WriteLine(TextForNum1());
                    num1 = getNum();
                    Console.WriteLine(TextForNum2());
                    num2 = getNum();
                    result = calculator.Subtract(num1, num2);
                    Console.Write(SeeResult(result));
                    Console.ReadLine();
                    break;

                case "3":
                    operate = "/";
                    Console.WriteLine(TextForNum1());
                    num1 = getNum();
                    Console.WriteLine(TextForNum2());
                    num2 = getNum();
                    result = calculator.Divide(num1, num2);
                    Console.Write(SeeResult(result));
                    Console.ReadLine();
                    break;

                case "4":
                    operate = "*";
                    Console.WriteLine(TextForNum1());
                    num1 = getNum();
                    Console.Write(TextForNum2());
                    num2 = getNum();
                    result = calculator.Multiply(num1, num2);
                    Console.Write(SeeResult(result));
                    Console.ReadLine();
                    break;

                case "5":
                    calculator.SeeLog();
                    Console.ReadLine();
                    break;

                case "6":
                    run = false;
                    break;

                default:
                    break;
            }
            calculator.UppdateLog(num1, num2, result, operate);
        }

        public static string TextForNum1()
        {
            return "First number: ";
        }
        public static string TextForNum2()
        {
            return "Second number: ";
        }

        public static double getNum()
        {
            double.TryParse(Console.ReadLine(), out double number);
            return number;
        }

        public static string SeeResult(double result)
        {
            return $"Answer: \n{result}";
        }
    }
}