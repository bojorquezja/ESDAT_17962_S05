using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colales{
    class Nodo{
        public string Dato { get; set; }
        public Nodo Sig { get; set; }

        public Nodo(string dato) {
            Dato = dato;
        }

        public Nodo() {
        }
    }
}
