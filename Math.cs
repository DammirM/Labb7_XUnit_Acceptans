using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_XUnit_Acceptans
{
    public class Math
    {
        public List<Logg> log;
        public Math()
        {
            log = new List<Logg>();
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public Logg UppdateLog(double number1, double number2, double result, string operate)
        {
            string input1 = number1.ToString();
            string input2 = number2.ToString();
            string output = result.ToString();
            Logg newLog = new Logg(input1, input2, output, operate);
            log.Add(newLog);
            return newLog;
        }

        public void SeeLog()
        {
            foreach (var item in log)
            {
                Console.Write($"{item.Num1} {item.Operate} {item.Num2} = {item.Output}\n");
            }
        }
    }
}
