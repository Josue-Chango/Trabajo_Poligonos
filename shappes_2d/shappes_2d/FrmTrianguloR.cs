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
    public partial class FrmTrianguloR : Form
    {
        float baseT = 0;
        float alturaT = 0;
        bool dibujar = false;
        public FrmTrianguloR()
        {
            InitializeComponent();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtBase.Text) &&
            Validador.Validar<float>(txtAltura.Text))
            {
                baseT = float.Parse(txtBase.Text);
                alturaT = float.Parse(txtAltura.Text);
                double hipotenusa = Math.Sqrt(Math.Pow(baseT, 2) + Math.Pow(alturaT, 2));
                txtHipotenusa.Text = hipotenusa.ToString("F2");
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa valores numéricos válidos.");
            }
        }

        private void txtHipotenusa_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTrianguloR_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.DibujarTrianguloRectangulo(g, baseT, alturaT);
        }

        private void FrmTrianguloR_Load(object sender, EventArgs e)
        {

        }
    }
}
