using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shappes_2d
{
    public partial class FrmCorazon : Form
    {
        float tamañoCorazon = 0;
        bool dibujar = false;
        public FrmCorazon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCorazon_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.DibujarCorazon(g, tamañoCorazon);
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCorazon_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtTamaño.Text))
            {
                tamañoCorazon = float.Parse(txtTamaño.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el tamaño.");
            }
        }
    }
}
