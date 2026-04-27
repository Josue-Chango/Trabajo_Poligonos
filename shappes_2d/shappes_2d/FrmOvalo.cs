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
    public partial class FrmOvalo : Form
    {
        float radioMayor=0;
        float radioMenor=0;
        bool dibujar=false;
        public FrmOvalo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtSMayor.Text) && Validador.Validar<int>(txtSMenor.Text))
            {
                radioMayor = int.Parse(txtSMayor.Text);
                radioMenor = int.Parse(txtSMenor.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaOvalo(radioMayor, radioMenor);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroOvalo(radioMayor, radioMenor);
                Invalidate();

            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos");
            }

        }

        private void FrmOvalo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarOvalo(g, radioMayor, radioMenor);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            radioMayor = 0; radioMenor = 0;
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
