using System;
namespace staticSinif{
    class Program{
        public static void Main(string[] args){
            int s = Calisan.CalisanSayisi;
            Calisan calisan = new Calisan("Ayse","yildirim","IK");

            Islemler.Topla(12,55);
            Islemler.Cikar(15,5);
        }
    }
    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi{
            get => calisanSayisi;
        }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim,string departman){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        } 
    }

    static class Islemler{
            public static long Topla(int sayi1, int sayi2){
                return sayi1 + sayi2;
            }
            public static long Cikar(int sayi1, int sayi2){
                return sayi1 - sayi2;
            }

        }
}