using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace colales{
    class ColaLES{
        Nodo Primero { get; set; }

        public void Enqueue(string valor) {
            Nodo nuevo = new Nodo(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            } else //caso 2
              {
                Nodo tmp = this.Primero;
                while (tmp.Sig != null) {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public void Dequeue() {
            if (this.Primero == null) // Caso 1: La lista está vacía
            {
                return;
            } else if (this.Primero.Sig == null) // Caso 2: Solo hay un vagón
            {
                this.Primero = null;
                return;
            } else {
                Nodo segundo = this.Primero.Sig;
                Primero.Sig = null;
                Primero = segundo;
            }
            
        }

        public bool Empty() {
            return this.Primero == null;
        }

        public int Size() {
            if (this.Primero == null) {
                return 0;
            } else {
                int cant = 0;
                Nodo tmp = this.Primero;
                while (tmp != null) {
                    cant++;
                    tmp = tmp.Sig;
                }
                return cant;
            }
        }

        public string GetValor(int pos) {
            int indice = 0;
            Nodo tmp = this.Primero;
            while (tmp != null) {
                if (indice == pos) {
                    return tmp.Dato;
                }
                indice++;
                tmp = tmp.Sig;
            }
            return "";
        }

        public void SetValor(int pos, string valor) {
            int indice = 0;
            Nodo tmp = this.Primero;
            while (tmp != null) {
                if (indice == pos) {
                    tmp.Dato = valor;
                }
                indice++;
                tmp = tmp.Sig;
            }
        }

        public override string? ToString() {
            string todo = "";
            Nodo tmp = this.Primero;
            while (tmp != null) {
                todo += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return todo;
        }
    }
}
