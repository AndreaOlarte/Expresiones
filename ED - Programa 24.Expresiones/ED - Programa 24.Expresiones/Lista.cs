using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_24.Expresiones
{
    class Lista
    {
        private Nodo _inicio;
        public Nodo inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        private Nodo _fin;
        public Nodo fin
        {
            get { return _fin; }
            set { _fin = value; }
        }

        public void agregar(Nodo nodo) //Advertir de cuando al inicio o final ponen operadores
        {
            if (_inicio == null)
            {
                _inicio = nodo;
                _fin = nodo;
            }
            else
            {
                _fin.sig = nodo;
                nodo.ant = _fin;
                _fin = _fin.sig;
            }
        }
    }
}
