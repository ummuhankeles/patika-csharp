﻿using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
