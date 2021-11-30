using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int [] a = new int[15]; 
                int sum = 0;
                Random rnd = new Random();
                string s = null; 

                for (int i = 0; i < 15; i++)
                {
                    a [i] = rnd.Next(1, 100); 
                    s = s + a [i].ToString() + " "; 
                    sum = sum + a [i]; 
                }
                Console.WriteLine("Начальный массив: " + s); 
                Console.WriteLine("Среднее арифметическое: " + (sum / 15));
                s = null;
                for (int i = 0; i < 15; i++)
                {
                    a [i] = a [i] - (sum / 15);
                    s = s + a [i].ToString() + " ";
                }
                Console.WriteLine("Новый массив = " + s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
