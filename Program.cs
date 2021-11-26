using System;
using System.IO;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"E:\.net\Binary\Binary\Input.txt");
            using StreamWriter sw = new StreamWriter(@"E:\.net\Binary\Binary\Output.txt");

            string value = sr.ReadToEnd();
            Console.WriteLine(value);
            string[] result = value.Split(' ');
            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);

            int num = 0;
            num = (a * a) * b;
 
            Console.WriteLine(num);
            sw.WriteLine(num);

            Console.WriteLine();


        }
    }
}
