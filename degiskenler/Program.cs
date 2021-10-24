using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     // 1 byte
            sbyte c = 5;    // 1 byte

            short s = 4;    // 2 byte
            ushort us = 2;  // 2 byte

            Int16 i16 = 2;  // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 6;    // 4 byte
            long l = 6;     // 8 byte
            ulong  ul = 6;  // 8 byte

            float f = 2;    // 4 byte
            double d = 2;   // 8 byte
            decimal de = 2; // 16 byte

            char ch = 'i';    // 2 byte
            string str = "ümmühan";  // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "a";
            object o2 = 'i';
            object o3 = 3;
            object o4 = 3.4;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "ümmühan keleş";
            string name = "ümmühan";
            string surname = "keleş";
            string fullName = name + " " + surname;

            // integer ifadeler
            int integer1 = 5;
            int integer2 = 6;
            int integer3 = integer1 * integer2;

            // boolean
            bool bool1 = 10<2;

            // değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string newVal = str20 + int20.ToString();
            Console.WriteLine(newVal); // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // 40

            // datetime
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
