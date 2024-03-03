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
            
            lista.AddNodo(15);
            lista.AddNodo(5);
            lista.AddNodo(7);
            lista.AddNodo(4);
            Console.WriteLine(lista);
            lista.Order();

            Console.WriteLine(lista);
            lista.RemoveNodoByValue(7);
            lista.RemoveNodeByIndex(1);
            lista.ChangeValueByIndex(5, 222);
            Console.WriteLine(lista.FindByIndex(22));
            Console.WriteLine(lista);
            Console.ReadKey();
            


        }
    }
}
