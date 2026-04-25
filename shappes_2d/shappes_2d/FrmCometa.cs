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
    public partial class FrmCometa : Form
    {
        float anchoCometa = 0;
        float altoCometa = 0;
        bool dibujar = false;
        public FrmCometa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCometa_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            // Llamada limpia con solo dos parámetros
            figuras.DibujarCometa(e.Graphics, anchoCometa, altoCometa);

        }

        private void txtAncho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCruce_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            // Solo validamos Ancho y Alto
            if (Validador.Validar<float>(txtAncho.Text) &&
                Validador.Validar<float>(txtAlto.Text))
            {
                anchoCometa = float.Parse(txtAncho.Text);
                altoCometa = float.Parse(txtAlto.Text);

                dibujar = true;
                this.Invalidate();
            }
        }

        private void FrmCometa_Load(object sender, EventArgs e)
        {

        }
    }
}
