using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz
{
    class Matriz
    {
        private int[,] mat;

        public void Ingresar()
        {
            mat = new int[5, 3];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Ingrese valor de  posicion ["+(f+1)+","+(c+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Ingresar();
            ma.Imprimir();
        }
    }
}