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
    public partial class FrmPie : Form
    {
        float radioPie = 0;
        float gradosPie = 0;
        bool dibujar = false;
        public FrmPie()
        {
            InitializeComponent();
        }

        private void FrmPie_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();

            // Pasamos el radio y los grados capturados
            figuras.DibujarPie(g, radioPie, gradosPie);
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtRadio.Text) &&
            Validador.Validar<float>(txtGrados.Text))
            {
                radioPie = float.Parse(txtRadio.Text);
                gradosPie = float.Parse(txtGrados.Text);

                dibujar = true;
                this.Invalidate(); // Provoca que se ejecute el evento Paint
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos para el Radio y los Grados.");
            }
        }
    }
}
