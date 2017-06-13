using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ape_expresionesArbolesBinarios
{
    public partial class frmPrincipal : Form
    {
        Arbol arbol = new Arbol();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLeerExpresion_Click(object sender, EventArgs e)
        {
            arbol.leerExpresion(txtExpresión.Text);
            txtExpresión.Text = "";
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.inOrder();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.mostrar();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.preOrder() + Environment.NewLine;
            txtResultado.Text += arbol.resolverPreOrder().ToString();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.postOrder() + Environment.NewLine;
            txtResultado.Text += arbol.resolverPostOrder().ToString();
        }
    }
}
