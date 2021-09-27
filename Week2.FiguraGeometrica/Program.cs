// Scrivere un programma che calcola perimetro e area delle seguenti figure geometriche
// Tutte le figure geometriche hanno una proprietà Nome
// Cerchio -> coordinate del centro, raggio
// Rettangolo -> base, altezza
// Triangolo -> base, altezza, lato1, lato2
// Tutte le figure geometriche hanno un metodo che stampa il nome,
// un metodo che stampa il perimetro e
// un metodo che stampa l'area


using System;
using System.Collections.Generic;

namespace Week2.FiguraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {


            Centro centro = new Centro();
            centro.X = 3;
            centro.Y = 2;
            GetDatiCerchio(out double raggio);

            Cerchio c = new Cerchio("Cerchio", raggio, centro);
            c.Name = "Cerchio";

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{c.PrintNome()}");
            c.CalcolaPerimetro();
            c.CalcolaArea();
            Console.WriteLine("------------------------------------------------");

            GetDatiRettangolo(out double altezza, out double _base);
            Rettangolo r = new Rettangolo("Rettangolo", altezza, _base);
            r.Name = "Rettangolo";

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{r.PrintNome()}");
            r.CalcolaPerimetro();
            r.CalcolaArea();
            Console.WriteLine("------------------------------------------------");


            GetDatiTriangolo(out double _altezza, out double _baseT, out double cateto1, out double cateto2);
            Triangolo t = new Triangolo("Triangolo", _altezza, _baseT, cateto1, cateto2);
            t.Name = "Triangolo";

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{t.PrintNome()}");
            t.CalcolaPerimetro();
            t.CalcolaArea();
            Console.WriteLine("------------------------------------------------");

        }


        public static void GetDatiCerchio(out double raggio)
        {
            do
            {
                Console.Write($"Inserisci il raggio: ");
            } while (!double.TryParse(Console.ReadLine(), out raggio));
        }

        public static void GetDatiRettangolo(out double altezza, out double _base)
        {
            do
            {
                Console.Write($"Inserisci l'altezza del rettangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out altezza));

            do
            {
                Console.Write($"Inserisci la base del rettangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _base));
        }

        public static void GetDatiTriangolo(out double _altezza, out double _baseT, out double cateto1, out double cateto2)
        {

            do
            {
                Console.Write($"Inserisci l'altezza del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _altezza));

            do
            {
                Console.Write($"Inserisci la base del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out _baseT));

            do
            {
                Console.Write($"Inserisci il primo cateto del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out cateto1));

            do
            {
                Console.Write($"Inserisci il secondo cateto del triangolo: ");
            } while (!double.TryParse(Console.ReadLine(), out cateto2));
        }
    }
}
