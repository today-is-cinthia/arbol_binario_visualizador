using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dato = 0;
        int cont = 0;

        Arbol_Binario mi_Arbol = new Arbol_Binario(null);
        Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtInsertar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtInsertar.Text);

                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    mi_Arbol.Insertar(Dato);

                    txtInsertar.Clear();
                    txtInsertar.Focus();

                    cont++;

                    Refresh();
                    Refresh();
                }

            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g=e.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtEliminar.Text);
                mi_Arbol.Eliminar(Dato);
                txtEliminar.Clear();
                txtEliminar.Focus();
                Refresh();
                Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtBuscar.Text);
                mi_Arbol.Buscar(Dato);
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
        }

        private void txtpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           mi_Arbol.PreOrden();
           mi_Arbol.PosOrden();
            mi_Arbol.InOrden();
        }
    }
}
