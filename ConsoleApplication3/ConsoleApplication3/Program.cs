using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入體重");
            string kg = Console.ReadLine();
            Console.WriteLine("請輸入身高");
            string cm = Console.ReadLine();

            double BMI = double.Parse(kg) / (double.Parse(cm) / 100 * double.Parse(cm) / 100);
            Console.ReadLine();
        }
    }
}
