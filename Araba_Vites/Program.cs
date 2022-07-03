using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_Vites
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac n = new Arac(1600, 2009);
            n.vergiHesapla();
            n.vitesArtir(3);
            n.aracyazdir();
        }
    }
    class Arac
    {
        int motorHacmi;
        int modelYili;
        int hiz;
        public int vites { get; set; }
        public int vergi { get; set; }
        public Arac(int motorhacmi, int modelyili)
        {
            this.motorHacmi = motorhacmi;
            this.modelYili = modelyili;
        }
        public void vergiHesapla()
        {
            switch (motorHacmi)
            {
                case 1600:
                    vergi = 16000;
                    break;
                case 2000:
                    vergi = 40000;
                    break;
                case 2500:
                    vergi = 25 * 2500;
                    break;
                default:
                    Console.WriteLine("!motor hacmini yanlış girdiniz!");
                    break;
            }

        }
        public void vitesArtir(int _vites)
        {
            this.vites = _vites;
            hiz = vites * 20;
        }
        public void aracyazdir()
        {
            Console.WriteLine("Vites: " + vites);
            Console.WriteLine("Araç Hızı: " + hiz);
            Console.WriteLine("Model Yılı: "+ modelYili);
            Console.WriteLine("Motor Hacmi: "+motorHacmi);
            Console.WriteLine("Araç Vergisi: "+vergi);
            Console.ReadLine();
            
        }
    }
}
