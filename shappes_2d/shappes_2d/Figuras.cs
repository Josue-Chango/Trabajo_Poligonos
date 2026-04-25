using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shappes_2d
{
    /*internal class Figuras
    {
    }*/
    public class Figuras
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public Figuras(float weight, float height)
        {
            Weight = weight;
            Height = height;
        }
        public Figuras()
        {
        }

        public void DibujarRectangulo(Graphics g, float weight, float height)
        {
            if (weight < 6 && height < 6)
            {
                float redim_weight = weight * 4;
                float redim_height = height * 4;
                Pen pen = new Pen(Color.Blue, 2);
                g.DrawRectangle(Pens.Red, 350, 100, redim_weight, redim_height);
            }
            else
            {
                Pen pen = new Pen(Color.Blue, 2);
                g.DrawRectangle(Pens.Red, 350, 100, weight, height);
            }
        }

        public void DibujarTriangulo(Graphics g, float ladoA, float ladoB, float ladoC)
        {
            float a;
            float b;
            float c;
            if (ladoA < 10 && ladoB < 10 && ladoC < 10)
            {
                float escala = 10;
                a = ladoA * escala;
                b = ladoB * escala;
                c = ladoC * escala;
                PointF punto1 = new PointF(350, 100);
                PointF punto2 = new PointF(350 + a, 100);
                float cx = (a * a + b * b - c * c) / (2 * a);
                float cy = (float)Math.Sqrt(Math.Max(0, b * b - cx * cx));
                PointF punto3 = new PointF(350 + cx, 100 - cy);
                PointF[] points = { punto1, punto2, punto3 };
                //g.DrawPolygon(Pens.Red, points);
                g.FillPolygon(Brushes.LightBlue, points);
            }
            else
            {
                a = ladoA;
                b = ladoB;
                c = ladoC;
                PointF punto1 = new PointF(350, 100);
                PointF punto2 = new PointF(350 + a, 100);
                float cx = (a * a + b * b - c * c) / (2 * a);
                float cy = (float)Math.Sqrt(Math.Max(0, b * b - cx * cx));
                PointF punto3 = new PointF(350 + cx, 100 - cy);
                PointF[] puntos = { punto1, punto2, punto3 };
                //g.DrawPolygon(Pens.Red, puntos);
                g.FillPolygon(Brushes.LightBlue, puntos);
            }
        }

        public void DibujarParalelogramo(Graphics g, int ladoA, int ladoB, double anguloGrados)
        {
            float a = ladoA;
            float b = ladoB;

            // Aplicar escala si los valores son muy pequeños (como en tus otros métodos)
            if (ladoA < 10 && ladoB < 10)
            {
                float escala = 10;
                a = ladoA * escala;
                b = ladoB * escala;
            }

            // Punto de anclaje similar a tus otras figuras
            float x = 350;
            float y = 150;

            // Convertir ángulo a radianes
            double radianes = anguloGrados * (Math.PI / 180.0);

            // Calcular desplazamiento para la inclinación
            float desplazamientoX = (float)(b * Math.Cos(radianes));
            float desplazamientoY = (float)(b * Math.Sin(radianes));

            // Definir los 4 puntos del paralelogramo
            PointF p1 = new PointF(x, y);
            PointF p2 = new PointF(x + a, y);
            PointF p3 = new PointF(x + a + desplazamientoX, y - desplazamientoY);
            PointF p4 = new PointF(x + desplazamientoX, y - desplazamientoY);

            PointF[] puntos = { p1, p2, p3, p4 };

            // Configurar suavizado para que no se vea pixelado
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Rellenar con el color azul claro que usas en el triángulo
            g.FillPolygon(Brushes.LightBlue, puntos);

            // Dibujar el borde (Pen azul de 2px como pediste)
            using (Pen lapiz = new Pen(Color.Blue, 2))
            {
                g.DrawPolygon(lapiz, puntos);
            }
        }

        public void DibujarRombo(Graphics g, float lado, double anguloGrados)
        {
            float l = lado;
            // Escala para valores pequeños
            if (lado < 10) { l = lado * 10; }

            // Punto central donde se dibujará el rombo
            float centerX = 350;
            float centerY = 150;

            // Para un rombo "parado", calculamos los vértices arriba, abajo, izquierda y derecha.
            // El ángulo aquí define qué tan "estirado" está el rombo.
            double radianes = (anguloGrados / 2) * (Math.PI / 180.0);

            // Calculamos las distancias desde el centro a las puntas
            float semiDiagonalHorizontal = (float)(l * Math.Cos(radianes));
            float semiDiagonalVertical = (float)(l * Math.Sin(radianes));

            // Definimos los 4 puntos cardinales del rombo
            PointF superior = new PointF(centerX, centerY - semiDiagonalVertical);
            PointF derecha = new PointF(centerX + semiDiagonalHorizontal, centerY);
            PointF inferior = new PointF(centerX, centerY + semiDiagonalVertical);
            PointF izquierda = new PointF(centerX - semiDiagonalHorizontal, centerY);

            PointF[] puntos = { superior, derecha, inferior, izquierda };

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Relleno
            g.FillPolygon(Brushes.Thistle, puntos);

            // Contorno
            using (Pen lapiz = new Pen(Color.Purple, 2))
            {
                g.DrawPolygon(lapiz, puntos);
            }
        }

        public void DibujarCometa(Graphics g, float ancho, float alto)
        {
            float w = ancho;
            float h = alto;

            if (ancho < 10) { w *= 10; h *= 10; }

            float centerX = 350;
            float centerY = 150;

            // ELIMINADO: Ya no recibimos el parámetro. 
            // Ahora lo calculamos nosotros (0.25f es el 25% del alto)
            float pSup = h * 0.25f;

            PointF superior = new PointF(centerX, centerY - pSup);
            PointF derecha = new PointF(centerX + (w / 2), centerY);
            PointF inferior = new PointF(centerX, centerY + (h - pSup));
            PointF izquierda = new PointF(centerX - (w / 2), centerY);

            PointF[] puntos = { superior, derecha, inferior, izquierda };

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(new SolidBrush(Color.FromArgb(188, 153, 203)), puntos);

            using (Pen lapiz = new Pen(Color.FromArgb(60, 60, 90), 2))
            {
                g.DrawPolygon(lapiz, puntos);
            }
        }
        public void DibujarHexagono(Graphics g, float lado)
        {
            float a = lado;
            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
                PointF centro = new PointF(350, 100);
                PointF[] puntos = new PointF[6];
                for (int i = 0; i < 6; i++)
                {
                    float angle = (float)(i * Math.PI / 3);
                    puntos[i] = new PointF(
                        centro.X + a * (float)Math.Cos(angle),
                        centro.Y + a * (float)Math.Sin(angle)
                    );
                }
                //g.DrawPolygon(Pens.Red, puntos);
                //g.FillPolygon(Brushes.LightBlue, puntos);
                Brush[] brushes = new Brush[]
                {
                    Brushes.Red,
                    Brushes.Green,
                    Brushes.Blue,
                    Brushes.Yellow,
                    Brushes.Orange,
                    Brushes.Purple
                };

                for (int i = 0; i < 6; i++)
                {
                    PointF[] triangulo = new PointF[3];
                    triangulo[0] = centro; 
                    triangulo[1] = puntos[i];
                    triangulo[2] = puntos[(i + 1) % 6];

                    g.FillPolygon(brushes[i % brushes.Length], triangulo);
                }
            }
            else
            {
                PointF centro = new PointF(350, 100);
                PointF[] puntos = new PointF[6];
                for (int i = 0; i < 6; i++)
                {
                    float angle = (float)(i * Math.PI / 3);
                    puntos[i] = new PointF(
                        centro.X + a * (float)Math.Cos(angle),
                        centro.Y + a * (float)Math.Sin(angle)
                    );
                }
                //g.DrawPolygon(Pens.Red, puntos);
                //g.FillPolygon(Brushes.LightBlue, puntos);

                Brush[] brushes = new Brush[]
                {
                    Brushes.Red,
                    Brushes.Green,
                    Brushes.Blue,
                    Brushes.Yellow,
                    Brushes.Orange,
                    Brushes.Purple
                };

                for (int i = 0; i < 6; i++)
                {
                    PointF[] triangulo = new PointF[3];
                    triangulo[0] = centro;
                    triangulo[1] = puntos[i];
                    triangulo[2] = puntos[(i + 1) % 6];

                    g.FillPolygon(brushes[i % brushes.Length], triangulo);
                }


            }
        }
    }
}
