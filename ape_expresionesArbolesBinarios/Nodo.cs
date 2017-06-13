using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_expresionesArbolesBinarios
{
    class Nodo
    {
        public string dato;
        public Nodo siguiente, anterior, izq, der;

        public Nodo(string dato)
        {
            this.dato = dato;
            siguiente = null;
            anterior = null;
            izq = null;
            der = null;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
