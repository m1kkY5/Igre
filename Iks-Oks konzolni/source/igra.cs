using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Igra
{
    public class polja
    {
        public int py;
        public int px;
        public bool popunjeno;
        public char znak;

        public polja(int y, int x, char z, bool p)
        {
            py = y;
            px = x;
            znak = z;
            popunjeno = p;
        }
    }

    public class io
    {
        static polja[,] polje = new polja[dim, dim];
        static int potez = 1;
        const int dim = 3;

        private static void tablica()
        {
            Console.Write(" {0} | {1} | {2}", polje[0, 0].znak, polje[0, 1].znak, polje[0, 2].znak);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.Write(" {0} | {1} | {2}", polje[1, 0].znak, polje[1, 1].znak, polje[1, 2].znak);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.Write(" {0} | {1} | {2}", polje[2, 0].znak, polje[2, 1].znak, polje[2, 2].znak);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void generisi(ref char[,] tabela)
        {
            string p = "abcdefghi";
            int count = 0;

            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                    tabela[i, j] = p[count++];
        }

        private static void obj()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    polja P = new polja(i, j, ' ', false);
                    polje[i, j] = P;
                }
            }
        }

        private static void popuniX(int y, int x, char[,] tabela)
        {
            if (polje[y, x].popunjeno == false)
            {
                tabela[y, x] = 'X';
                polje[y, x].znak = 'X';
                polje[y, x].popunjeno = true;
                Console.Clear();
            }
            else
            {
                Console.Clear();
                potez--;
            }
        }

        private static void popuniO(int y, int x, char[,] tabela)
        {
            if (polje[y, x].popunjeno == false)
            {
                tabela[y, x] = 'O';
                polje[y, x].znak = 'O';
                polje[y, x].popunjeno = true;
                Console.Clear();
            }
            else
            {
                Console.Clear();
                potez--;
            }
        }

        private static void prvi(ref char[,] tabela)
        {
            Console.Write("I igrac\nPozicija: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    popuniX(2, 0, tabela);
                    break;
                case ConsoleKey.NumPad2:
                    popuniX(2, 1, tabela);
                    break;
                case ConsoleKey.NumPad3:
                    popuniX(2, 2, tabela);
                    break;
                case ConsoleKey.NumPad4:
                    popuniX(1, 0, tabela);
                    break;
                case ConsoleKey.NumPad5:
                    popuniX(1, 1, tabela);
                    break;
                case ConsoleKey.NumPad6:
                    popuniX(1, 2, tabela);
                    break;
                case ConsoleKey.NumPad7:
                    popuniX(0, 0, tabela);
                    break;
                case ConsoleKey.NumPad8:
                    popuniX(0, 1, tabela);
                    break;
                case ConsoleKey.NumPad9:
                    popuniX(0, 2, tabela);
                    break;
            }
        }

        private static void drugi(ref char[,] tabela)
        {
            Console.Write("II igrac\nPozicija: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    popuniO(2, 0, tabela);
                    break;
                case ConsoleKey.NumPad2:
                    popuniO(2, 1, tabela);
                    break;
                case ConsoleKey.NumPad3:
                    popuniO(2, 2, tabela);
                    break;
                case ConsoleKey.NumPad4:
                    popuniO(1, 0, tabela);
                    break;
                case ConsoleKey.NumPad5:
                    popuniO(1, 1, tabela);
                    break;
                case ConsoleKey.NumPad6:
                    popuniO(1, 2, tabela);
                    break;
                case ConsoleKey.NumPad7:
                    popuniO(0, 0, tabela);
                    break;
                case ConsoleKey.NumPad8:
                    popuniO(0, 1, tabela);
                    break;
                case ConsoleKey.NumPad9:
                    popuniO(0, 2, tabela);
                    break;
            }
        }

        private static bool proveriKolone(char[,] tabela)
        {

            if (tabela[0, 0] == tabela[1, 0] && tabela[1, 0] == tabela[2, 0] ||
                tabela[0, 1] == tabela[1, 1] && tabela[1, 1] == tabela[2, 1] ||
                tabela[0, 2] == tabela[1, 2] && tabela[1, 2] == tabela[2, 2])
                return true;
            else
                return false;

        }

        private static bool proveriRedove(char[,] tabela)
        {
            if (tabela[0, 0] == tabela[0, 1] && tabela[0, 1] == tabela[0, 2] ||
                tabela[1, 0] == tabela[1, 1] && tabela[1, 1] == tabela[1, 2] ||
                tabela[2, 0] == tabela[2, 1] && tabela[2, 1] == tabela[2, 2])
                return true;
            else
                return false;
        }

        private static bool proveriDijagonale(char[,] tabela)
        {
            if (tabela[0, 0] == tabela[1, 1] && tabela[1, 1] == tabela[2, 2] ||
                tabela[2, 0] == tabela[1, 1] && tabela[1, 1] == tabela[0, 2])
                return true;
            else
                return false;
        }

        private static int pobednik(int potez)
        {
            if (potez == 10)
            {
                Console.WriteLine("Nereseno");
                return 0;
            }
            if (potez % 2 == 1)
            {
                Console.WriteLine("Igrac I je pobedio nakon {0} poteza", potez);
                return 0;
            }
            else
            {
                Console.WriteLine("Igrac II je pobesio nakon {0} poteza", potez);
                return 0;
            }

        }

        public static void play()
        {
            obj();

            char[,] tabela = new char[dim, dim];

            generisi(ref tabela);

            tablica();
            while (potez < 10)
            {

                if (potez % 2 == 1)
                    prvi(ref tabela);
                else
                    drugi(ref tabela);

                if (proveriKolone(tabela) == true ||
                    proveriRedove(tabela) == true ||
                    proveriDijagonale(tabela) == true)
                    break;

                potez++;
                tablica();

            }
            Thread.Sleep(1000);
            Console.Clear();
            pobednik(potez);
            Console.ReadLine();
        }
    }
}
