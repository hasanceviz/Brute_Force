using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bruteforcealgo
{
    class Brute_Force
    {
        static void Main(string[] args)
        {
            Console.WriteLine("harfleri arasında boşluk olmadan  giriniz.");
            string harfler = Console.ReadLine();
            Console.WriteLine("kaç haneli şifre istediğinizi giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var cozum = new Brute_Force();
            cozum.Sifre("",sayi,harfler);
            Console.ReadLine();
        }

        public void Sifre(string anahtar,int sayi,string kelime)
        {
            char[] cevap = kelime.ToCharArray();
            int sayi2 = Convert.ToInt32(anahtar.Length);
            if (sayi2 == sayi)
            {
            string kayit = AppDomain.CurrentDomain.BaseDirectory + " sifreee.text";
            File.AppendAllText(kayit, Environment.NewLine + anahtar);
            Console.WriteLine(anahtar);
            }

            if(anahtar.Length == kelime.Length)
            {
                return;
            }
            for (int c = 0; c < kelime.Length; c++)
            {
                Sifre(anahtar+kelime[c],sayi,kelime);
            }

        }
    }
}
