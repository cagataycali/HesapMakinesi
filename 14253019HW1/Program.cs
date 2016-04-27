using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253019HW1
{
    class Program
    {
        static void Main(string[] args)
        {

        baslangic:

            /**
           *  Kullanıcıdan bir sayı alalım
           */
            Console.WriteLine("Bir sayı giriniz");
            string sayi1 = Console.ReadLine();


            /**
            * İşlemi alalım
            */
            Console.WriteLine("İşlemi giriniz");
            string islem = Console.ReadLine();


            /**
            * Bir sayı daha alalım
            */
            Console.WriteLine("Bir sayı giriniz");
            string sayi2 = Console.ReadLine();
            

            /**
            * İnput extraction
            */
            ExtractInput extract = new ExtractInput();

            /**
            * Gelen inputun içerisindeki tamsayıları yakalayalım.
            */
            int sayi_1 = extract.extractInput(sayi1);
            int sayi_2 = extract.extractInput(sayi2);

            /**
            * İşlem 
            */
            Islem islemYap = new Islem();

            /**
            * İşlemi yapalım
            */
            float yanit = islemYap.islemYap(sayi_1, sayi_2, islem);

            Console.WriteLine(yanit);

            Console.WriteLine("Lütfen  devam etmek istemiyorsanız h tuşuna basıp gönderin!");
            string devam = Console.ReadLine();

            if (devam != "h")
            {
                goto baslangic;
            }
        }
    }
}
