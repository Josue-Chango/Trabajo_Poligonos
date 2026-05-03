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
    public partial class FrmLuna : Form
    {
        float radioLuna = 0;
        bool dibujar = false;
        public FrmLuna()
        {
            InitializeComponent();
        }

        private void FrmLuna_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLuna_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarLuna(e.Graphics, radioLuna);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtRadio.Text))
            {
                radioLuna = float.Parse(txtRadio.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el radio.");
            }
        }
    }
}
