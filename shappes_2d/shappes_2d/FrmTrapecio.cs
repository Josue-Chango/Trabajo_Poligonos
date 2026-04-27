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
    public partial class FrmTrapecio : Form
    {
        int base_mayor = 0;
        int base_menor = 0;
        int lado_izquierdo = 0;
        int lado_derecho = 0;
        bool dibujar = false;
        public FrmTrapecio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtBaseMayor.Text) && Validador.Validar<int>(txtBaseMenor.Text) && Validador.Validar<int>(txtLadoIzquierdo.Text) && Validador.Validar<int>(txtLadoDerecho.Text) && Validador.ValidarTrapecio(int.Parse(txtLadoIzquierdo.Text), int.Parse(txtLadoDerecho.Text), int.Parse(txtBaseMayor.Text), int.Parse(txtBaseMenor.Text)))
            {
                base_mayor = int.Parse(txtBaseMayor.Text);
                base_menor = int.Parse(txtBaseMenor.Text);
                lado_izquierdo = int.Parse(txtLadoIzquierdo.Text);
                lado_derecho = int.Parse(txtLadoDerecho.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaTrapecio(base_mayor, base_menor, lado_izquierdo, lado_derecho);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroTrapecio(base_mayor, base_menor, lado_izquierdo, lado_derecho);
                Invalidate();




            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos o debe existir el trapecio");
            }
        }

        private void FrmTrapecio_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarTrapecio(g, base_mayor, base_menor, lado_izquierdo, lado_derecho);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            base_mayor = 0;
            base_menor = 0;
            lado_derecho = 0;
            lado_izquierdo = 0;
            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtLadoDerecho.Text = "";
            txtLadoIzquierdo.Text = "";
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
