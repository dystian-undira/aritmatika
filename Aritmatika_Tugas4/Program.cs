using System;

namespace Aritmatika
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Program Menghitung luas persegi panjang
            int selected = 0;
            double angka_1 = 0, angka_2 = 0, result = 0;
            
            Console.WriteLine("List Operator yang bisa digunakan: ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Modulus(Sisa Bagi)");
            
            Console.Write("Pilih operasi di atas : ");
            selected = Int16.Parse(Console.ReadLine());
            
            Console.Write("\nMasukan angka 1 : ");
            angka_1 = Int16.Parse(Console.ReadLine());
            
            Console.Write("Masukan angka 2 : ");
            angka_2 = Int16.Parse(Console.ReadLine());
            
            if (selected == 1)
            {
                result = angka_1 + angka_2;
            }
            else if (selected == 2)
            {
                result = angka_1 - angka_2;
            } 
            else if (selected == 3)
            {
                result = angka_1 * angka_2;
            }
            else if (selected == 4)
            {
                result = angka_1 % angka_2;
            }
            else
            {
                Console.WriteLine("Sorry, yang anda masukan tidak ada di pilihan!");
            }
            
            Console.WriteLine($"\nHasil dari operasi yang anda inginkan adalah {result}");
        }
    }
}