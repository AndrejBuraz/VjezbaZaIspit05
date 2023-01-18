using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- PRVI ZADATAK -----");
            /*
             Napišite program u kojem ćete deklarirati varijable a, b, c, i d tipa double, 
            te im dodijelite proizvoljne vrijednosti. 
            Deklarirajte varijablu x tipa double kojoj dodijelite vrijednost sljedećeg matematičkog izraza:a2 + b2 + c2 + d2
            __________________
            (a + b)2 + (c + d)2*/

            double a = 5.13, b = 88.121, c = 91.231, d = 0.00012;
            double x1 =  (Math.Pow(a,2) + Math.Pow(b,2) + Math.Pow(c,2) + Math.Pow(d,2)) / (Math.Pow((a+b), 2) + Math.Pow((c+d),2));
            Console.WriteLine("Vrijednost varijable x: " + x1);

            /*Napišite program u kojem ćete definirati sljedeće dvije varijable tipa string:
                • s1 sa sadržajem "Hrvatska ima more"
                • s2 sa sadržajem "Italija je prvak svijeta"
              Definirajte i ispišite string s3 čiji će sadržaj biti prvih 8 znakova stringa s1 plus svi znakovi od
              sedmog do kraja niza s2.*/

            Console.WriteLine("\n----- ZADATAK 2 -----");
            string s1 = "Hrvatska ima more", s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8) + s2.Substring(7);
            Console.WriteLine(s3);

            /*Napišite program koji će zatražiti od korisnika da unese neku rečenicu te će ispisati prvu i
             zadnju riječ te rečenice.*/

            Console.WriteLine("\n----- ZADATAK 3 -----");
            string recenica;
            Console.WriteLine("Unesi recenicu: ");
            recenica = Console.ReadLine();
            string[] rijeci = recenica.Split(' ');
            Console.WriteLine("Prva rijec: " + rijeci[0] + "\nZadnja rijec: " + rijeci[rijeci.Length - 1]);

            /*Napišite program u kojem ćete zatražiti od korisnika da unese jedan cijeli i jedan decimalni
              broj odvojene razmakom. Dvostruke vrijednosti unešenih brojeva spremite u odgovarajuće
              varijable x i y, te ih ispišite.*/

            Console.WriteLine("\n----- ZADATAK 4 -----");
            string niz;
            Console.WriteLine("Unesi jedan cijeli i jedan decimalni broj odvojen razmakom: ");
            niz = Console.ReadLine();
            string[] brojevi = niz.Split(' ');
            double x2 = Convert.ToDouble(brojevi[0]);
            double y = Convert.ToDouble(brojevi[1]);
            Console.WriteLine("X vrijednost: " + x2);
            Console.WriteLine("Y vrijednost: " + y);
            Console.ReadKey();
        }
    }
}
