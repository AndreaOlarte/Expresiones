using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_24.Expresiones
{
    class Procesador
    {
        private string _cadena;
        private Stack<float> _pilaFinal = new Stack<float>();

        public float resolverPre(Arbol arbol)
        {
            _cadena = arbol.preOrder();

            for (short j = 0; j < _cadena.Length; j++)
            {
                char caracter = _cadena[_cadena.Length - 1 - j];
                switch (caracter)
                {
                    case '*':
                        _pilaFinal.Push(_pilaFinal.Pop() * _pilaFinal.Pop());
                        break;
                    case '/':
                        _pilaFinal.Push((float)_pilaFinal.Pop() / _pilaFinal.Pop());
                        break;
                    case '+':
                        _pilaFinal.Push(_pilaFinal.Pop() + _pilaFinal.Pop());
                        break;
                    case '-':
                        _pilaFinal.Push(_pilaFinal.Pop() - _pilaFinal.Pop());
                        break;
                    default:
                        _pilaFinal.Push(int.Parse(caracter.ToString()));
                        break;
                }
            }
            return _pilaFinal.Pop();
        }

        public float resolverPost(Arbol arbol)
        {
            _cadena = arbol.postOrder();

            for (short j = 0; j < _cadena.Length; j++)
            {
                char caracter = _cadena[j];
                float ultimo;
                switch (caracter)
                {
                    case '*':
                        ultimo = _pilaFinal.Pop();
                        _pilaFinal.Push(_pilaFinal.Pop() * ultimo);
                        break;
                    case '/':
                        ultimo = _pilaFinal.Pop();
                        _pilaFinal.Push((float)_pilaFinal.Pop() / ultimo);
                        break;
                    case '+':
                        ultimo = _pilaFinal.Pop();
                        _pilaFinal.Push(_pilaFinal.Pop() + ultimo);
                        break;
                    case '-':
                        ultimo = _pilaFinal.Pop();
                        _pilaFinal.Push(_pilaFinal.Pop() - ultimo);
                        break;
                    default:
                        _pilaFinal.Push(int.Parse(caracter.ToString()));
                        break;
                }
            }
            return _pilaFinal.Pop();
        }

        public float resolverx2(string cadena)
        {
            for (short j = 0; j < cadena.Length; j++)
            {
                char caracter = cadena[cadena.Length - 1 - j];
                switch (caracter)
                {
                    case '*':
                        _pilaFinal.Push(_pilaFinal.Pop() * _pilaFinal.Pop());
                        break;
                    case '/':
                        _pilaFinal.Push((float)_pilaFinal.Pop() / _pilaFinal.Pop());
                        break;
                    case '+':
                        _pilaFinal.Push(_pilaFinal.Pop() + _pilaFinal.Pop());
                        break;
                    case '-':
                        _pilaFinal.Push(_pilaFinal.Pop() - _pilaFinal.Pop());
                        break;
                    default:
                        _pilaFinal.Push(int.Parse(caracter.ToString()));
                        break;
                }
            }
            return _pilaFinal.Pop();
        }
    }
}
