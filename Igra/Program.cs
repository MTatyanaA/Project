﻿
class Program
 {
    static void SelectRase()
    {
        string[] namesRase = {"Люди", "Эльфы", "Орки", "Гоблины", "Гномы"};
        for(int i = 0; i < namesRase.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesRase[i] + ", "); 
        }
        Console.WriteLine(namesRase.Length + " - " + namesRase[namesRase.Length-1] + ". ");
        Console.WriteLine("Укажите вашу расу?");
        int numberRase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса: " + namesRase[numberRase-1]);
    }
    static void SelectSex()
    {
        string[] namesSex = {"Женский", "мужской" };
        for(int i = 0; i < namesSex.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesSex[i] + ", "); 
        }
        Console.WriteLine(namesSex.Length + " - " + namesSex[namesSex.Length-1] + ". ");
        Console.WriteLine("Укажите ваш пол? ");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол: " + namesSex[numberSex-1]);
    }
        static void SelectClass()
    {
        string[] namesClass = {"Воин", "Охотник", "Маг", "Шаман", "Разбойник"};
        WriteSelect(namesClass);
        Console.WriteLine("Укажите ваш класс?");
        int numberClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс: " + namesClass[numberClass-1]);
    }
    static void WriteSelect(string[] args)
    {
          for(int i = 0; i < args.Length-1; i++)
         {
            Console.Write(i+1 + " - " + args[i] + ", "); 
         }
        Console.WriteLine(args.Length + " - " + args[args.Length-1] + ". ");
    }      

    static void Main(string[] args)
   {
         SelectRase();
         SelectSex();
         SelectClass();
   }
     }