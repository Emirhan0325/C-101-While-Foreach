using System;

namespace degisken
{
    class program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayı)
            {
                toplam += sayac;
                sayac++; 

            }
            Console.WriteLine(toplam / sayı);

            // "a" dan "z" ye kadar tüm harfleri console a yazdır
            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("****** Foreach ******");

            string arabalar = "Bmw, Mercedes, Ferrari, Nissan";
            foreach (var araba in arabalar)
            {
                Console.Write(araba);
            }

        }
        
    }
}       
