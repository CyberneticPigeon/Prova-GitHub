using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGitHub 
{
    internal class Program
    {
        // funzione 1
        static int[] Funzione1(int[] array)
        {
            Console.Clear();
            Console.WriteLine("inserisci numero");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array2 = new int[array.Length + 1];
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
                p++;

            }
            array2[array.Length] = n;

            return array2;
        }

        // funzione 2

        static void Funzione2(int[] array)
        {
            StreamWriter sw = new StreamWriter(@".\prova.HTML");

            sw.Write("<html><body>");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    sw.Write($"{array[i]}");
                }
                else
                {
                    sw.Write($"{array[i]};");
                }
            }
            sw.Write("</body></html>");

            sw.Close();

            Console.Clear();
            Console.WriteLine("se apri la cartella bin/debug del file ora troverai un file html con l'array");
            Console.ReadLine();
        }

        // funzione 3

        static void Funzione3(int[] array)
        {
            int n = 0;

            Console.Clear();
            Console.WriteLine("Inserisci il numero da trovare nell'array");

            n = Convert.ToInt32(Console.ReadLine());
            bool pos = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine($"Il numero {n} si trova in poszione {i} ");
                    pos = true;
                }
            }

            if (pos == false)
            {
                Console.WriteLine($"Il numero {n} si trova in poszione -1 (non prensente) ");
            }

            Console.ReadLine();
        }

        // funzione 4

        static void Funzione4(ref int[] array)
        {
            Console.Clear();
            Console.WriteLine("Inserisci il numero da eliminare nell'array (1,2,3,4,5,6)");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    array[i] = 0;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.ReadLine();
        }

        // funzione 5

        static void Funzione5(ref int[] array)
        {
            Console.Clear();
            Console.WriteLine("Inserisci un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci la posizione");
            int pos = Convert.ToInt32(Console.ReadLine());

            array[pos] = n;
        }

        // funzione 6

        static void Funzione6()
        {
            StreamReader file = new StreamReader(@".\prova.HTML");
            string arraystringa = file.ReadLine();
            file.Close();

            int n = 0;
            int c = 0;

            // conto numeri

            for (int i = 0; i < arraystringa.Length; i++)
            {
                if (arraystringa[i] != ';')
                {
                    c++;
                }
            }

            // creazione array

            int[] array = new int[c];
            int posizione = 0;


            for (int i = 0; i < arraystringa.Length; i++)
            {
                if (arraystringa[i] != ';')
                {
                    array[posizione] = arraystringa[i];
                    posizione++;
                }
            }

            Console.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            bool v = true;// per rendere il programma infinito
            int scelta = 0;
            while (v == true)
            {
                bool uscita = false;

                // ciclo while per verificare che l'input sia corretto
                while (uscita == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tMENU'");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("scegli funzione: \n 1\t:Aggiungere in coda un elemento all'array (interi) \n 2:\tVisualizzazione dell'array che restituisca la stringa in HTML \n 3:\tRicerca un numero all'interno dell'array, la funzione deve restituire la posizione dell'elemento se lo trova, -1 se non lo trova \n 4:\tCancellazione di un elemento dell'array \n  5:\tInserimento di un valore in una posizione dell'array\n6:\t Leggere con un file esterno (formato a scelta) in maniera sequenziale i valori dell'array.");
                    Console.ForegroundColor = ConsoleColor.White;

                    scelta = Convert.ToInt32(Console.ReadLine());

                    if (scelta < 1 | scelta > 6)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tInput errato. Inserisci un numero da 1 a 5");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                    else
                    {
                        uscita = true;
                    }
                }

                // SCELTA FUNZIONE

                switch (scelta)
                {
                    case 1:
                        int[] array2 = Funzione1(array);
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        break;

                    case 2:
                        Funzione2(array);
                        break;

                    case 3:
                        Funzione3(array);
                        break;
                    case 4:
                        Funzione4(ref array);
                        break;
                    case 5:
                        Funzione5(ref array);
                        break;
                    case 6:
                        Funzione6();
                        break;
                }

            }

        }
    }
}