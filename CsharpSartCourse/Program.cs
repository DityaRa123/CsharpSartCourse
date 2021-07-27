using System;

namespace CsharpSartCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine("Привет," + name + "!");
        }
    }
}
