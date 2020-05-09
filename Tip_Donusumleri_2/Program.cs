using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Donusumleri_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan 3 sayının ortalamasını gösteren program.
            int sayi1, sayi2, sayi3, ortalama;
            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            ortalama = (sayi1 + sayi2 + sayi3) / 3;
            Console.Write("Bu sayıların ortalaması: " + ortalama);
            Console.ReadKey();
        }
    }
}
// Ekrandan yakalanan herşey string olarak yakalanır. Yakalanan değeri hangi tipe dönüştüreceksek convert yapılır. Console.ReadLine() string bir sonuç getirir. Sayısal değer girmek için dönüştürme yapıldı.