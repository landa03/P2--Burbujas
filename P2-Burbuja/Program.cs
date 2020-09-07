using System;

namespace P2_Burbuja
{
    class Program
    {
        public static int numero1 = new int();
        public static int numero2 = new int();
        static int numero3 = new int();
        static int numero4 = new int();
        static void Burbujas()
        {
            System.Console.WriteLine("escrive 4 numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());
            numero4 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();

            int min1 = Math.Min(numero1, numero2);
            int min2 = Math.Min(numero3, numero4);
            int min12 = Math.Min(min1, min2);

            int max1 = Math.Max(numero1, numero2);
            int max2 = Math.Max(numero3, numero4);
            int max12 = Math.Max(max1, max2);

            int max3 = Math.Max(min1, min2);
            int min3 = Math.Min(max1, max2);

            int midle1 = Math.Min(max3, min3);
            int midle2 = Math.Max(max3, min3);

            System.Console.Write(min12);
            System.Console.Write(", ");
            System.Console.Write(midle1);
            System.Console.Write(", ");
            System.Console.Write(midle2);
            System.Console.Write(", ");
            System.Console.Write(max12);
        }       
        static void Main(string[] args)
        {
            Burbujas();
        }
    }
}
// por un momento paresia inposible asta que me yego una epifania