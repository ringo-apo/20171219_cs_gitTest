using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1番目の数字を入力してください");
            string a = Console.ReadLine();
            int b = int.Parse(a);

            Console.WriteLine("2番目の数字を入力してください");
            string c = Console.ReadLine();
            int d = int.Parse(c);

            int e = b + d;
            string f = e.ToString();
            Console.WriteLine("1番目と2番目の数字の合計は{0}です。",f);

        }
    }
}
