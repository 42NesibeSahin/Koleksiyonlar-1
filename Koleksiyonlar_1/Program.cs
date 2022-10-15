using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList tekListe = new ArrayList();
            ArrayList ciftList = new ArrayList();
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ". sayıyı giriniz: ");
                bool num = int.TryParse(Console.ReadLine(),out int sayi);
                if (num && sayi>0)
                {
                    if (sayi % 2 == 0)
                        ciftList.Add(sayi);
                    else
                        tekListe.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Hatalı sayi girişi tekrar giriniz...");
                    i--;
                }
                
            }

            tekListe.Sort();
            ciftList.Sort();

            Console.WriteLine(" **********   Tek sayilar  *********");
            foreach (var item in tekListe)
                Console.WriteLine(item);

            Console.WriteLine(" **********   Çift sayilar  *********");
            foreach (var item in ciftList)
                Console.WriteLine(item);

            int toplamTek = 0;
            int toplamcift = 0;

            foreach (var item in tekListe)
                toplamTek +=(int)item;

            foreach (var item in ciftList)
                toplamcift += (int)item;

            Console.WriteLine("Tek sayilarin toplami: " + toplamTek + " ortalaması: " +toplamTek / tekListe.Count);
            Console.WriteLine("çift sayilarin toplami: " + toplamcift + " ortalaması: " +toplamcift / ciftList.Count);

            Console.ReadLine();
        }
    }
}
