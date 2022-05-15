using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetidosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 3, 9, 4, 9, 16, 3, 8 };
            bool repetidos = false;
            for(var x = 0; x < lista.Length; x++)
            {
                int a = lista[x];
                int c = x + 1;
                for(int y = c;y < lista.Length; y++)
                {
                    int b = lista[y];
                    if(a == b)
                    {
                        repetidos = true;
                        System.Console.WriteLine("El numero " + a + " esta repetido en la lista.");
                    }
                }
            }
            if(repetidos == false)
            {
                System.Console.WriteLine("No hay numeros repetidos en la lista.");
            }
        }
    }
}
