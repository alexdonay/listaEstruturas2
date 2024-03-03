using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaEstrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List lista = new List();
            
            lista.addNodo(15);
            lista.addNodo(5);
            lista.addNodo(7);
            lista.addNodo(4);
            Console.WriteLine(lista);
            lista.order();

            Console.WriteLine(lista);
            lista.removeNodoByValue(7);
            lista.removeNodeByIndex(1);
            lista.changeValueByIndex(5, 222);
            Console.WriteLine(lista);
            Console.ReadKey();
            


        }
    }
}
