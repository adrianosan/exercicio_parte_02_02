using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_parte_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Double anos = 0, resultado, preco;//numcig =número de cigarros
            int numcig = 0;
            Console.Write("Digite o número de cigarros que fumar por dia. ");
            numcig = int.Parse(Console.ReadLine());
            Console.Write("Digite quantidade de anos que ele fumar. ");
            anos = Double.Parse(Console.ReadLine());
            Console.Write("Digite o preço do maço de cigarros por dia. ");
            preco = Double.Parse(Console.ReadLine());

            resultado = ((anos * 365) * numcig) / 20;

            if (((anos * 365) * numcig) % 20 == 0)
            {
                resultado *= preco;
            }

            else
            {
                resultado += 1;
                resultado *= preco;
            }

            Console.WriteLine("Valor gasto em maço de cigarros: {0}", resultado);
            
            
        }
    }
}
