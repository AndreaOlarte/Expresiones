using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa_24.Expresiones
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();
        Arbol arbol = new Arbol();
        Procesador procesador = new Procesador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            string cadena = txtExpresion.Text;
            lista.inicio = null;
            lista.fin = null;
            for (short i = 0; i < cadena.Length; i++)
                lista.agregar(new Nodo(cadena[i]));
            arbol.obtenerArbol(lista);
            txtInfo.Text = procesador.resolverPre(arbol).ToString();
        }

        private void btnResolverPost_Click(object sender, EventArgs e)
        {
            string cadena = txtExpresion.Text;
            lista.inicio = null;
            lista.fin = null;
            for (short i = 0; i < cadena.Length; i++)
                lista.agregar(new Nodo(cadena[i]));
            arbol.obtenerArbol(lista);
            txtInfo.Text = procesador.resolverPost(arbol).ToString();
        }
    }
}
