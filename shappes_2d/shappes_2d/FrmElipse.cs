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
    public partial class FrmElipse : Form
    {
        float SMayor = 0;
        float SMenor = 0;
        bool dibujar = false;
        public FrmElipse()
        {
            InitializeComponent();
        }

        private void FrmElipse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;
            Figuras figuras = new Figuras();
            figuras.DibujarElipse(g, SMayor, SMenor);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (Validador.Validar<int>(txtSMayor.Text) && Validador.Validar<int>(txtSMenor.Text))
            {
                SMayor = int.Parse(txtSMayor.Text);
                SMenor = int.Parse(txtSMenor.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaElipse(SMayor, SMenor);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroElipse(SMayor, SMenor);
                Invalidate();
            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            SMayor = 0; SMenor = 0;
            txtSMayor.Text = "";
            txtSMenor.Text = "";
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
            Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
