using System;
using System.Collections.Generic;
using System.Threading;

namespace SinemaUygulaması
{
    internal class Program
    {
        static FilmBilgileri flm;
        static void Main(string[] args)
        {
            Kurulum();
            Uygulama();
            Console.WriteLine();

            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;

                    case "2":
                    case "R":
                        Biletİade();
                        break;

                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;

                    case "4":
                    case "X":
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine();

                //Test();

            }

        //static void Test()
        //{

        //    while (true)
        //    {
        //        Console.Write("Sayı girin :");
        //        string giris = Console.ReadLine();

        //        int sayi;

        //        bool sonuc = int.TryParse(giris, out sayi);

        //        if (sonuc == true)
        //        {
        //            Console.WriteLine(sayi);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Hatalı giriş yapıldı.");
        //        }
        //    }

        }

        static int SayiAl(string mesaj)
        {
            int sayi;

            while(true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if(int.TryParse(giris , out sayi))
                {
                    return sayi;
                }
                
              Console.WriteLine("Hatalı giriş yapıldı.");
                
            }
        }


        static void BiletSat()
        {
            
                Console.WriteLine("Bilet Sat:");
                
                int tam = SayiAl("Tam bilet adeti: ");

            Console.Write("Yarım bilet adeti: ");
                int yarim = SayiAl("Yarim bilet adeti");

                flm.BiletSatisi(tam, yarim);
            
            

          



        }

        static void Biletİade()
        {
            Console.WriteLine("Bilet İade:");
            
                int tam = SayiAl("Tam bilet adeti: ");

                
                int yarim = SayiAl("Yarım bilet adeti");


                flm.BiletIadesi(tam, yarim);


        }

        

        static void DurumBilgisi()
        {
            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + flm.FilmAdi);
            Console.WriteLine("Kapasite: " + flm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı: " + flm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı: " + flm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adedi: " + flm.ToplamTamBiletAdeti);
            Console.WriteLine("Toplam Yarım Bilet Adedi: " + flm.ToplamYarimBiletAdeti);
            Console.WriteLine("Ciro: " + flm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + flm.BosKoltukAdediGetir());
        }




        static void Uygulama()
        {

        }
        static void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı: ");
            string film = Console.ReadLine();

            Console.Write("Kapasite: ");
            int kapasite = int.Parse(Console.ReadLine());

            Console.Write("Tam bilet fiyatı: ");
            int tam = int.Parse(Console.ReadLine());

            Console.Write("Yarım bilet fiyatı: ");
            int yarim = int.Parse(Console.ReadLine());
            Console.WriteLine();

            

            flm = new FilmBilgileri(film, kapasite, tam, yarim);

            Menu();

            

        }
        static void Menu()
        {
            Console.WriteLine("1- Bilet Sat (S)");
            Console.WriteLine("2- Bilet İade (R)");
            Console.WriteLine("3- Durum Bilgisi (D)");
            Console.WriteLine("4- Çıkış (X)");


        }

        static string SecimAl()
        {


            string karakterler = "1234SRDX";
            int sayac = 0;

            while (true)
            {
                sayac++;
                Console.Write("Seçiminiz : ");
                string giris = Console.ReadLine().ToUpper();
                int index = karakterler.IndexOf(giris);

                Console.WriteLine();

                if (giris.Length == 1 && index >= 0)
                {
                    return giris;
                }

                else
                {
                    if (sayac == 10)
                    {
                        Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                        Environment.Exit(0);
                    }


                    Console.WriteLine("Hatalı giriş yapıldı.");
                }
                Console.WriteLine();
            }
        }

        }


}
