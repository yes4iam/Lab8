using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\imark\Desktop\Автоматизация проектирования\Lesson 8\Lab 8\Lab 8\Temp\Task 2.txt";
            Random random = new Random();
            int sum = 0;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-20, 20));
                }
                                                       
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
                              
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
