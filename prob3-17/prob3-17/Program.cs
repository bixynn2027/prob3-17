using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100)：");
            int a = int.Parse(Console.ReadLine());
            if (a <= 0 || a > 100)
            {
                Console.WriteLine("適切な値を入力してください");
            }
            if (a < 50 && a % 2 == 0)
            {
                Console.WriteLine("50以下の偶数です");
            }
            else if (a < 50)
            {
                Console.WriteLine("50以下です");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("偶数です");
            }
        }
    }
}
