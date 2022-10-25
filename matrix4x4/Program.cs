using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz4
{
    class Matriz4
    {
        private int[,] mat;

        public void Cargar() 
        {
            mat=new int[4,4];
            for(int f = 0; f < 4; f++) 
            {
                for(int c = 0; c<4; c++) 
                {
                    Console.Write("Ingrese el valor de la  componente:");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirDiagonalPrincipal()
        {
            for(int k = 0; k < 4; k++) 
            {
                Console.Write(mat[k,k]+" ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz4 ma = new Matriz4();
            ma.Cargar();
            ma.ImprimirDiagonalPrincipal();
        }
    }
}
