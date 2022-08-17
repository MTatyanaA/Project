using System;

namespace Новая_папка
{ 
    class Program
    {
       
        static void Main(string[] args)
     {
        while (true)
        {
             int number = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(Math.Abs(number));  // Модуль
             Console.WriteLine(Math.Sqrt(number));  // Корень числа
             Console.WriteLine(Math.Round(Math.Sqrt(number), 1));  // Целое
             Console.WriteLine(Math.Pow(number, 10));  //Степень
             Console.WriteLine("y/n");
             if(Console.ReadLine() == "n") break;
        }
        
     }   
        }
    }

