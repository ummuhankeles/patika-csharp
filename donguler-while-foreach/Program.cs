﻿using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1 den başlayarak console dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp consola yazdıran program
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console a yazdır
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine();

            // foreach
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
