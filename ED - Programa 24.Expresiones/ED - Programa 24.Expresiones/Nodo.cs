using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_24.Expresiones
{
    class Nodo
    {
        private char _caracter;
        public char caracter
        {
            get { return _caracter; }
        }

        private Nodo _izq;
        public Nodo izq
        {
            get { return _izq; }
            set { _izq = value; }
        }

        private Nodo _der;
        public Nodo der
        {
            get { return _der; }
            set { _der = value; }
        }

        private Nodo _ant;
        public Nodo ant
        {
            get { return _ant; }
            set { _ant = value; }
        }

        private Nodo _sig;
        public Nodo sig
        {
            get { return _sig; }
            set { _sig = value; }
        }

        public Nodo(char caracter)
        {
            _caracter = caracter;
        }

        public override string ToString()
        {
            return caracter.ToString();
        }
    }
}
