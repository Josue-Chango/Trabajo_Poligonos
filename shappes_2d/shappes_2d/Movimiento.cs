using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shappes_2d
{
    internal class Movimiento
    {
        public float X = 0;
        public float Y = 0;

        public float Escala = 1;

        public float Rotacion = 0;

        public void AplicarTransformaciones(Graphics g, float centroX, float centroY)
        {
            if (Escala <= 0)
                Escala = 0.1f;

           
            g.TranslateTransform(centroX + X, centroY + Y);

        
            g.RotateTransform(Rotacion);

          
            g.ScaleTransform(Escala, Escala);

         
            g.TranslateTransform(-centroX, -centroY);
        }

        
        public void CambiarEscala(float nuevaEscala)
        {
            Escala = nuevaEscala;

            if (Escala <= 0)
                Escala = 0.1f;
        }

     
        public void ControlTeclado(KeyEventArgs e)
        {
            int paso = 10;

            if (e.KeyCode == Keys.Left)
                X -= paso;

            if (e.KeyCode == Keys.Right)
                X += paso;

            if (e.KeyCode == Keys.Up)
                Y -= paso;

            if (e.KeyCode == Keys.Down)
                Y += paso;

            if (e.KeyCode == Keys.A)
                Rotacion -= 5;

            if (e.KeyCode == Keys.D)
                Rotacion += 5;
        }
    }
}
