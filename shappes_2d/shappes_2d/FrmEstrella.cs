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
    public partial class FrmEstrella : Form

    {
        float radioE = 0;
        bool dibujar = false;
        public FrmEstrella()
        {
            InitializeComponent();
        }

        private void FrmEstrella_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEstrella_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.DibujarEstrella(g, radioE);
        }

        

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtRadio.Text))
            {
                radioE = float.Parse(txtRadio.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el radio.");
            }
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
