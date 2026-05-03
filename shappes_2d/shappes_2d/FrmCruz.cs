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
    public partial class FrmCruz : Form
    {
        float grosorCruz = 0;
        bool dibujar = false;
        public FrmCruz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCruz_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarCruz(e.Graphics, grosorCruz);

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtGrosor.Text))
            {
                grosorCruz = float.Parse(txtGrosor.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el tamaño.");
            }

        }

        private void txtGrosor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCruz_Load(object sender, EventArgs e)
        {

        }
    }
}
