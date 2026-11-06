using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ej_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CmbRecorridos.SelectedIndex = 0;
        }

        ArbolBinario arbol = new ArbolBinario();

        void RefrescarVistaArbol()
        {
            TvArbol.Nodes.Clear();
            if (!arbol.EstaVacio())
            {
                TreeNode nodovisualraiz = crearNodoVisual(arbol.Raiz);
                TvArbol.Nodes.Add(nodovisualraiz);
                TvArbol.ExpandAll();
            }
        }

        TreeNode crearNodoVisual(NodoArbol nodo)
        {
            TreeNode nodovisual = new TreeNode(nodo.Dato.ToString());
            nodovisual.Tag = nodo;

            if (nodo.Izquierdo != null)
            {
                nodovisual.Nodes.Add(crearNodoVisual(nodo.Izquierdo));

            }
            if (nodo.Derecho != null)
            {
                nodovisual.Nodes.Add(crearNodoVisual(nodo.Derecho));
            }
            return nodovisual;
        }

        private void BtnAddRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbDato.Text == "")
                {
                    MessageBox.Show("Ingrese un valor!");
                    return;
                }

                if (!arbol.EstaVacio())
                {
                    MessageBox.Show("El arbol ya tiene raiz!");
                    return;
                }

                arbol.Raiz = new NodoArbol(int.Parse(TbDato.Text.Trim()));
                TbDato.Clear();
                RefrescarVistaArbol();
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numericos");
            }

        }

        private void BtnAddIzq_Click(object sender, EventArgs e)
        {

            try
            {
                if (TvArbol.SelectedNode == null)
                {
                    MessageBox.Show("Seleccione un nodo!");
                    return;
                }

                if (TbDato.Text == "")
                {
                    MessageBox.Show("Ingrese un valor!");
                    return;
                }

                NodoArbol nodoselected = (NodoArbol)TvArbol.SelectedNode.Tag;

                if (nodoselected.Izquierdo != null)
                {
                    MessageBox.Show("El nodo seleccionado ya tiene un hijo izquierdo.", "Error");
                    return;
                }
                nodoselected.Izquierdo = new NodoArbol(int.Parse(TbDato.Text.Trim()));
                TbDato.Clear();
                RefrescarVistaArbol();
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numericos");
            }


        }

        private void BtnAddDerecha_Click(object sender, EventArgs e)
        {


            try
            {
                if (TvArbol.SelectedNode == null)
                {
                    MessageBox.Show("Seleccione un nodo!");
                    return;
                }

                if (TbDato.Text == "")
                {
                    MessageBox.Show("Ingrese un valor!");
                    return;
                }

                NodoArbol nodoselected = (NodoArbol)TvArbol.SelectedNode.Tag;

                if (nodoselected.Derecho != null)
                {
                    MessageBox.Show("El nodo seleccionado ya tiene un hijo derecho.", "Error");
                    return;
                }
                nodoselected.Derecho = new NodoArbol(int.Parse(TbDato.Text.Trim()));
                TbDato.Clear();
                RefrescarVistaArbol();
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numericos");
            }


        }

        private void BtnRecorrer_Click(object sender, EventArgs e)
        {
            if (arbol.EstaVacio())
            {
                MessageBox.Show("El árbol está vacío.", "Atención");
                return;
            }

            LbResultado.Items.Clear();

            Action<NodoArbol> accionvisitar = n => LbResultado.Items.Add(n.Dato);

            string tipoRecorrido = CmbRecorridos.SelectedItem.ToString();


            switch (tipoRecorrido)
            {
                case "Preorden":
                    arbol.Preorden(arbol.Raiz, accionvisitar);
                    break;
                case "Inorden":
                    arbol.Inorden(arbol.Raiz, accionvisitar);
                    break;
                case "Postorden":
                    arbol.Postorden(arbol.Raiz, accionvisitar);
                    break;
            }
        }
    }
}