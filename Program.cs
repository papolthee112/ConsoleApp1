using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("อายุ: ");
            int age = int.Parse(Console.ReadLine());

            int birthYear = DateTime.Now.Year - age;

            string gen =
                birthYear <= 1980 ? "Gen X" :
                birthYear <= 1996 ? "Gen Y" :
                birthYear <= 2012 ? "Gen Z" :
                "Gen Alpha";

            Console.WriteLine($"เกิดปี {birthYear}, คุณเป็น {gen}");

        }
    }
}
