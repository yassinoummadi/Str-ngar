using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strängar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Console.WriteLine("\u0056\xE4\u0157\x6D\u0064\u00f6" + " " + "\x47\x79\x6D\x6E\x61\x73\x69\x75\x6D");
            */

            /* Övning 2
            Console.WriteLine("\u0022\u0048\u0065\u006c\u006c\u006f \u0057\u006f\u0072\u006c\u0064\u0022");
            */

            /* Övning 3
            
            a)
            string inmatat = "\"Hello World\"";
            string ord = inmatat.ToUpper();

            Console.WriteLine(ord);

            b)
            
            string inmatat = "\"Hello World\"";
            string ord = inmatat.ToLower();

            Console.WriteLine(ord);

            */


            /* Övning 4
            string inmatat = "\"Hello World\"";

            Console.WriteLine("\"Hello World\" innehåller " + inmatat.Length + " tecken.");

            */

            /* Övning 5
            Console.WriteLine("Skriv en text: ");
            string inmatat = Console.ReadLine();

            for (int i = inmatat.Length-1; i >=0 ; i--)
            {
                Console.Write(inmatat[i]);
            }

            Console.ReadLine();
            */

            /* Övning 6 (Kunde dock inte få 3-5-7-9 elefanter balanserade..)
            string text = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n"
                                    + "Det tyckte {2} var så intressant,\n"
                                    + "så {2} gick och hämtade en annan elefant.\n";

            string helatexten = string.Format(text, "En", "", "han");
            Console.WriteLine(helatexten);

            for (int i = 1; i < 10; i++)
            {
                helatexten = string.Format(text, ++i, "er", "de");
                Console.WriteLine(helatexten);
            }
            */

        }

    }
}
