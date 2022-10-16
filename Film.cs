using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulaması
{
    internal class FilmBilgileri
    {
        public string FilmAdi{ get; set; }
        public int Kapasite{ get; }
        public int TamBiletFiyati{ get; }
        public int YarimBiletFiyati{ get; }
        public int ToplamTamBiletAdeti{ get; private set; }
        public int ToplamYarimBiletAdeti{ get; private set; }
        public float Ciro
        {

            get
            {
                return this.ToplamTamBiletAdeti * this.TamBiletFiyati + ToplamYarimBiletAdeti * this.YarimBiletFiyati;
            }
        
            
        }
            
        

        
        public FilmBilgileri(string filmadi, int kapasite, int tam, int yarim)
        {
            this.FilmAdi = filmadi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam;
            this.YarimBiletFiyati = yarim;
        }

        public void BiletSatisi(int tamBiletadeti, int yarimBiletAdeti)
        {
            if(ToplamTamBiletAdeti + ToplamYarimBiletAdeti >= BosKoltukAdediGetir())
            {
             this.ToplamTamBiletAdeti += tamBiletadeti;
             this.ToplamYarimBiletAdeti += yarimBiletAdeti;
             //CiroHesapla(); 
             Console.WriteLine();
             Console.WriteLine("İşlem Gerçekleştirildi.");   
            }
            else
            {
                Console.WriteLine((tamBiletadeti+yarimBiletAdeti) + "adet boş koltuk olmadığından işlem gerçekleşmedi.");
            }

            
        }
        public void BiletIadesi(int tamBiletadeti, int yarimBiletAdeti)
        {
            if(tamBiletadeti <= this.ToplamTamBiletAdeti && yarimBiletAdeti <= this.ToplamYarimBiletAdeti)
            {
                this.ToplamTamBiletAdeti -= tamBiletadeti;
                this.ToplamYarimBiletAdeti -= yarimBiletAdeti;
                //CiroHesapla();
                Console.WriteLine("İşlem Gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Satılmış olan bilet sayısından fazla iade yapılamaz.");
            }
        }
        //private void CiroHesapla()
        //{
        //    this.Ciro = this.ToplamTamBiletAdeti * this.TamBiletFiyati + ToplamYarimBiletAdeti * this.YarimBiletFiyati;
        //}
        public int BosKoltukAdediGetir()
        {
            int BosKoltukAdedi = Kapasite - ToplamTamBiletAdeti - ToplamYarimBiletAdeti;
            return BosKoltukAdedi;
        }
    }
}
