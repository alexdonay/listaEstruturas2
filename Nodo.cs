using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaEstrutura
{
    internal class Nodo
    {
        public int value;
        public Nodo nextNodo;
        public Nodo(int value)
        {
            this.value = value;
        }
    }
}
