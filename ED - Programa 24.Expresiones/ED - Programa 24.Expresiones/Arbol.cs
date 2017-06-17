using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_24.Expresiones
{
    class Arbol
    {
        private Nodo _raiz;

        public void obtenerArbol(Lista lista) //Habilitar para validar
        {
            Nodo auxiliar = lista.inicio;
            if (auxiliar != null)
            {
                while (auxiliar != null)
                {
                    if (auxiliar.caracter == '*' || auxiliar.caracter == '/')
                        reordenarEnlaces(auxiliar, lista);
                    auxiliar = auxiliar.sig;
                }

                auxiliar = lista.inicio;
                while (auxiliar != null)
                {
                    if (auxiliar.caracter == '+' || auxiliar.caracter == '-')
                        reordenarEnlaces(auxiliar, lista);
                    auxiliar = auxiliar.sig;
                }
                
                _raiz = lista.fin; //CUIDADO, está bien?
            }
        }

        

        private void reordenarEnlaces(Nodo aux, Lista lista)
        {
            aux.izq = aux.ant;
            aux.der = aux.sig;
            if (aux.ant.ant != null)
            {
                aux.ant = aux.izq.ant;
                aux.ant.sig = aux;
            }
            else
            {
                lista.inicio = aux;
                aux.ant = null; //
            }

            if (aux.sig.sig != null)
            {
                aux.sig = aux.der.sig;
                aux.sig.ant = aux;
            }
            else
            {
                lista.fin = aux;
                aux.sig = null; //
            }

            aux.izq.ant = null; //
            aux.izq.sig = null; //
            aux.der.ant = null; //
            aux.der.sig = null; //
        }

        public string preOrder()
        {
            if (_raiz == null)
                return "";
            else
                return preOrder(_raiz);
        }

        private string preOrder(Nodo raiz)
        {
            string cadena = "";
            cadena += raiz.ToString();
            if (raiz.izq != null)
                cadena += preOrder(raiz.izq);
            if (raiz.der != null)
                cadena += preOrder(raiz.der);
            return cadena;
        }

        public string postOrder()
        {
            if (_raiz == null)
                return "";
            else
                return postOrder(_raiz);
        }

        private string postOrder(Nodo raiz)
        {
            string cadena = "";
            if (raiz.izq != null)
                cadena += postOrder(raiz.izq);
            if (raiz.der != null)
                cadena += postOrder(raiz.der);
            cadena += raiz.ToString();
            return cadena;
        }
    }
}
