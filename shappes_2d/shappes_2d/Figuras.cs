using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace shappes_2d
{
    /*internal class Figuras
    {
    }*/
    public class Figuras
    {
        private Calculos calc = new Calculos();
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
        public void DibujarParalelogramo(Graphics g, float baseP, float ladoB, double anguloGrados)
        {
            float b = baseP < 10 ? baseP * 10 : baseP;
            float l = ladoB < 10 ? ladoB * 10 : ladoB;
            double rad = anguloGrados * (Math.PI / 180.0);

            float dx = (float)(l * Math.Cos(rad));
            float h = (float)(l * Math.Sin(rad));

            PointF[] pts = {
                new PointF(350, 200),
                new PointF(350 + b, 200),
                new PointF(350 + b + dx, 200 - h),
                new PointF(350 + dx, 200 - h)
            };

            g.FillPolygon(Brushes.LightBlue, pts);
            g.DrawPolygon(new Pen(Color.Blue, 2), pts);

            float area = calc.CalcularAreaParalelogramo(baseP, (float)(ladoB * Math.Sin(rad)));
            float peri = calc.CalcularPerimetroParalelogramo(baseP, ladoB);
            g.DrawString($"A: {area:F2}\nP: {peri:F2}", SystemFonts.DefaultFont, Brushes.Black, 350, 210);
        }

        public void DibujarTrianguloEquilatero(Graphics g, float lado)
        {
            float l = lado < 10 ? lado * 10 : lado;
            float h = (float)((Math.Sqrt(3) / 2) * l);

            PointF[] pts = {
        new PointF(350, 150 - (h / 2)),
        new PointF(350 + (l / 2), 150 + (h / 2)),
        new PointF(350 - (l / 2), 150 + (h / 2))
    };

            g.FillPolygon(Brushes.LightCyan, pts);
            g.DrawPolygon(Pens.Blue, pts);

            g.DrawString($"A: {calc.CalcularAreaTrianguloEquilatero(lado):F2}\nP: {calc.CalcularPerimetroTrianguloEquilatero(lado):F2}",
                SystemFonts.DefaultFont, Brushes.Black, 350, 70);
        }

        public void DibujarTrianguloRectangulo(Graphics g, float baseT, float alturaT)
        {
            float b = baseT < 10 ? baseT * 10 : baseT;
            float h = alturaT < 10 ? alturaT * 10 : alturaT;

            PointF[] pts = {
                new PointF(350, 150),           
                new PointF(350 + b, 150),       
                new PointF(350, 150 - h)      
            };

            g.FillPolygon(Brushes.LightGreen, pts);
            g.DrawPolygon(Pens.Green, pts);

            g.DrawString($"A: {calc.CalcularAreaTrianguloRectangulo(baseT, alturaT):F2}\nP: {calc.CalcularPerimetroTrianguloRectangulo(baseT, alturaT):F2}",
                SystemFonts.DefaultFont, Brushes.Black, 350, 160);
        }


        public void DibujarTrianguloEscaleno(Graphics g, float ladoA, float ladoB, float ladoC)
        {
            if (ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA)
            {
                return;
            }

            float a = ladoA;
            float b = ladoB;
            float c = ladoC;
            if (a < 15) { a *= 10; b *= 10; c *= 10; }

            float x = 350;
            float y = 200;
            float cx = (b * b + c * c - a * a) / (2 * c);
            float cy = (float)Math.Sqrt(Math.Max(0, b * b - cx * cx));

            PointF p1 = new PointF(x, y);
            PointF p2 = new PointF(x + c, y);
            PointF p3 = new PointF(x + cx, y - cy);
            PointF[] puntos = { p1, p2, p3 };

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(Brushes.LightBlue, puntos);
            using (Pen lapiz = new Pen(Color.Blue, 2))
            {
                g.DrawPolygon(lapiz, puntos);
            }

            float areaFinal = calc.CalcularAreaTrianguloEscaleno(ladoA, ladoB, ladoC);
            float perimetroFinal = calc.CalcularPerimetroTrianguloEscaleno(ladoA, ladoB, ladoC);

            Font fuente = new Font("Arial", 10, FontStyle.Bold);
            g.DrawString($"Área: {areaFinal:F2}", fuente, Brushes.Black, x, y + 15);
            g.DrawString($"Perímetro: {perimetroFinal:F2}", fuente, Brushes.Black, x, y + 35);
        }

        public void DibujarRombo(Graphics g, float lado, double anguloGrados)
        {
            float l = lado < 10 ? lado * 10 : lado;
            double rad = (anguloGrados / 2) * (Math.PI / 180.0);

            float diagMayorEscala = (float)(l * Math.Cos(rad) * 2);
            float diagMenorEscala = (float)(l * Math.Sin(rad) * 2);

            PointF[] pts = {
        new PointF(350, 150 - (diagMenorEscala/2)),
        new PointF(350 + (diagMayorEscala/2), 150),
        new PointF(350, 150 + (diagMenorEscala/2)),
        new PointF(350 - (diagMayorEscala/2), 150)
    };

            g.FillPolygon(Brushes.Thistle, pts);
            g.DrawPolygon(new Pen(Color.Purple, 2), pts);

            // Cálculos (Usando diagonales reales para el área)
            float dM = (float)(lado * Math.Cos(rad) * 2);
            float dm = (float)(lado * Math.Sin(rad) * 2);
            g.DrawString($"A: {calc.CalcularAreaRombo(dM, dm):F2}\nP: {calc.CalcularPerimetroRombo(lado):F2}",
                SystemFonts.DefaultFont, Brushes.Black, 350, 80);
        }

        public void DibujarCometa(Graphics g, float diagonalMayor, float diagonalMenor)
        {
            float dM = diagonalMayor < 10 ? diagonalMayor * 10 : diagonalMayor;
            float dm = diagonalMenor < 10 ? diagonalMenor * 10 : diagonalMenor;

            float cruce = dM * 0.25f;

            PointF[] pts = {
        new PointF(350, 150 - cruce),              // Arriba
        new PointF(350 + (dm / 2), 150),           // Derecha
        new PointF(350, 150 + (dM - cruce)),       // Abajo
        new PointF(350 - (dm / 2), 150)            // Izquierda
    };

            g.FillPolygon(Brushes.Lavender, pts);
            g.DrawPolygon(new Pen(Color.DarkViolet, 2), pts);

            // Cálculo del área
            g.DrawString($"A: {calc.CalcularAreaCometa(diagonalMayor, diagonalMenor):F2}",
                SystemFonts.DefaultFont, Brushes.Black, 350, 80);
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

        public void DibujarCirculo(Graphics g, float radio)
        {
            float r = radio;
            if (radio < 10) { r = radio * 10; }
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawEllipse(pen, 350 - r, 100 - r, 2 * r, 2 * r);
            g.FillEllipse(Brushes.LightBlue, 350 - r, 100 - r, 2 * r, 2 * r);

        }

        public void DibujarElipse(Graphics g, float radioMayor, float radioMenor)
        {
            float rm = radioMayor;
            float rM = radioMenor;
            if (radioMayor < 10 && radioMenor < 10)
            {
                rm = radioMayor * 10;
                rM = radioMenor * 10;
            }
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawEllipse(pen, 350 - rm, 100 - rM, 2 * rm, 2 * rM);
            g.FillEllipse(Brushes.LightBlue, 350 - rm, 100 - rM, 2 * rm, 2 * rM);
        }

        public void DibujarOvalo(Graphics g, float radioMayor, float radioMenor)
        {
            float rm = radioMayor;
            float rM = radioMenor;
            if (radioMayor < 10 && radioMenor < 10)
            {
                rm = radioMayor * 10;
                rM = radioMenor * 10;
            }
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawEllipse(pen, 350 - rm, 100 - rM, 2 * rm, 2 * rM);
            g.FillEllipse(Brushes.LightBlue, 350 - rm, 100 - rM, 2 * rm, 2 * rM);
        }

        public void DibujarCuadrado(Graphics g, float lado)
        {
            float l = lado;
            if (lado < 10) { l = lado * 10; }
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, 350, 100, l, l);
            g.FillRectangle(Brushes.LightBlue, 350, 100, l, l);
        }


        public void DibujarTrapecio(Graphics g, float base_mayor, float base_menor, float lado_izquierdo, float lado_derecho)
        {
            float x = 350;
            float y = 150;
            float li = lado_izquierdo;
            float ld = lado_derecho;
            float bM = base_mayor;
            float bm = base_menor;

            if (base_mayor < 10 || base_menor < 10 || lado_derecho < 10 || lado_izquierdo < 10)
            {
                int escalado = 10;
                li = lado_izquierdo * escalado;
                ld = lado_derecho * escalado;
                bM = base_mayor * escalado;
                bm = base_menor * escalado;
            }

            float diferenciaTotal = bM - bm;


            float dx_li = (diferenciaTotal * diferenciaTotal + li * li - ld * ld) / (2 * diferenciaTotal);
            float h = (float)Math.Sqrt(Math.Max(0, li * li - dx_li * dx_li));

            PointF[] puntos = new PointF[]
            {
                new PointF(x, y),
                new PointF(x + bm, y),
                new PointF(x + bm + (diferenciaTotal - dx_li), y + h),
                new PointF(x - dx_li, y + h)
            };

            using (SolidBrush brocha = new SolidBrush(Color.Blue))
            using (Pen lapiz = new Pen(Color.Black, 2))
            {
                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }

        public void DibujarPentagono(Graphics g, float lado)
        {
            float a = lado;
            PointF centro = new PointF(350, 100);

            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
            }

            PointF[] puntos = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 5);
                puntos[i] = new PointF(
                    centro.X + a * (float)Math.Cos(angle),
                    centro.Y + a * (float)Math.Sin(angle)
                );
            }

            Brush[] brushes = new Brush[]
            {
        Brushes.Red,
        Brushes.Green,
        Brushes.Blue,
        Brushes.Yellow,
        Brushes.Orange
            };

            for (int i = 0; i < 5; i++)
            {
                PointF[] triangulo = new PointF[3];
                triangulo[0] = centro;
                triangulo[1] = puntos[i];
                triangulo[2] = puntos[(i + 1) % 5];

                g.FillPolygon(brushes[i % brushes.Length], triangulo);
            }

            g.DrawPolygon(Pens.Black, puntos);
        }

        public void DibujarHeptagono(Graphics g, float lado)
        {
            float a = lado;
            PointF centro = new PointF(350, 100);

            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
            }

            PointF[] puntos = new PointF[7];

            for (int i = 0; i < 7; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 7);
                puntos[i] = new PointF(
                    centro.X + a * (float)Math.Cos(angle),
                    centro.Y + a * (float)Math.Sin(angle)
                );
            }

            Brush[] brushes = new Brush[]
            {
        Brushes.Red,
        Brushes.Green,
        Brushes.Blue,
        Brushes.Yellow,
        Brushes.Orange,
        Brushes.Purple,
        Brushes.Cyan
            };

            for (int i = 0; i < 7; i++)
            {
                PointF[] triangulo = new PointF[3];
                triangulo[0] = centro;
                triangulo[1] = puntos[i];
                triangulo[2] = puntos[(i + 1) % 7];

                g.FillPolygon(brushes[i % brushes.Length], triangulo);
            }

            g.DrawPolygon(Pens.Black, puntos);
        }


        public void DibujarOctagono(Graphics g, float lado)
        {
            float a = lado;
            PointF centro = new PointF(350, 100);

            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
            }

            PointF[] puntos = new PointF[8];

            for (int i = 0; i < 8; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 8);
                puntos[i] = new PointF(
                    centro.X + a * (float)Math.Cos(angle),
                    centro.Y + a * (float)Math.Sin(angle)
                );
            }

            Brush[] brushes = new Brush[]
            {
        Brushes.Red,
        Brushes.Green,
        Brushes.Blue,
        Brushes.Yellow,
        Brushes.Orange,
        Brushes.Purple,
        Brushes.Cyan,
        Brushes.Magenta
            };

            for (int i = 0; i < 8; i++)
            {
                PointF[] triangulo = new PointF[3];
                triangulo[0] = centro;
                triangulo[1] = puntos[i];
                triangulo[2] = puntos[(i + 1) % 8];

                g.FillPolygon(brushes[i % brushes.Length], triangulo);
            }

            g.DrawPolygon(Pens.Black, puntos);
        }

        public void DibujarNonagono(Graphics g, float lado)
        {
            float a = lado;
            PointF centro = new PointF(350, 100);

            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
            }

            PointF[] puntos = new PointF[9];

            for (int i = 0; i < 9; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 9);
                puntos[i] = new PointF(
                    centro.X + a * (float)Math.Cos(angle),
                    centro.Y + a * (float)Math.Sin(angle)
                );
            }

            Brush[] brushes = new Brush[]
            {
        Brushes.Red,
        Brushes.Green,
        Brushes.Blue,
        Brushes.Yellow,
        Brushes.Orange,
        Brushes.Purple,
        Brushes.Cyan,
        Brushes.Magenta,
        Brushes.Brown
            };

            for (int i = 0; i < 9; i++)
            {
                PointF[] triangulo = new PointF[3];
                triangulo[0] = centro;
                triangulo[1] = puntos[i];
                triangulo[2] = puntos[(i + 1) % 9];

                g.FillPolygon(brushes[i % brushes.Length], triangulo);
            }

            g.DrawPolygon(Pens.Black, puntos);
        }

        public void DibujarDecagono(Graphics g, float lado)
        {
            float a = lado;
            PointF centro = new PointF(350, 100);

            if (lado < 10)
            {
                float escala = 4;
                a = lado * escala;
            }

            PointF[] puntos = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 10);
                puntos[i] = new PointF(
                    centro.X + a * (float)Math.Cos(angle),
                    centro.Y + a * (float)Math.Sin(angle)
                );
            }

            Brush[] brushes = new Brush[]
            {
        Brushes.Red,
        Brushes.Green,
        Brushes.Blue,
        Brushes.Yellow,
        Brushes.Orange,
        Brushes.Purple,
        Brushes.Cyan,
        Brushes.Magenta,
        Brushes.Brown,
        Brushes.OldLace,
            };

            for (int i = 0; i < 10; i++)
            {
                PointF[] triangulo = new PointF[3];
                triangulo[0] = centro;
                triangulo[1] = puntos[i];
                triangulo[2] = puntos[(i + 1) % 10];

                g.FillPolygon(brushes[i % brushes.Length], triangulo);
            }

            g.DrawPolygon(Pens.Black, puntos);
        }

        /*public void DibujarFlecha(Graphics g, float base_cuerpo, float altura_cuerpo, float base_cabeza, float altura_cabeza)
        {

            //Flecha Horizontal apuntando a la derecha
            PointF punto1 = new PointF(350, 150); 
            PointF punto2 = new PointF(350 + base_cuerpo, 150);
            PointF punto3 = new PointF(350 + base_cuerpo, 150 + (base_cabeza / 2) - base_cuerpo);
            PointF punto4 = new PointF(350 + base_cuerpo + altura_cabeza, 150 + altura_cabeza / 2); 
            PointF punto5 = new PointF(350 + base_cuerpo, 150 - (base_cabeza - (base_cabeza / 2) - base_cuerpo)); 
            PointF punto6 = new PointF(350 + base_cuerpo, 150 - base_cabeza); 
            PointF punto7 = new PointF(350, 150 - altura_cabeza); 
            //PointF punto8 = new PointF(350, 150); // Punto superior del cuerpo

            PointF[] Flecha = {punto1, punto2, punto3, punto4, punto5, punto6, punto7};

                g.FillPolygon(Brushes.Yellow, Flecha);
            }*/



        // --- ESTRELLA ---
        public void DibujarEstrella(Graphics g, float radioExterior)
        {
            float rExt = radioExterior < 10 ? radioExterior * 10 : radioExterior;
            float rInt = rExt * 0.4f;
            float centerX = 350, centerY = 150;
            PointF[] puntos = new PointF[10];
            double anguloInicial = -Math.PI / 2;

            for (int i = 0; i < 10; i++)
            {
                float r = (i % 2 == 0) ? rExt : rInt;
                double a = anguloInicial + i * (Math.PI / 5);
                puntos[i] = new PointF(centerX + (float)(r * Math.Cos(a)), centerY + (float)(r * Math.Sin(a)));
            }
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(Brushes.Yellow, puntos);
            g.DrawPolygon(new Pen(Color.Orange, 2), puntos);

            g.DrawString($"A: {calc.CalcularAreaEstrella(radioExterior):F2}", SystemFonts.DefaultFont, Brushes.Black, centerX - 30, centerY + rExt + 10);
        }

        // --- CORAZÓN ---
        public void DibujarCorazon(Graphics g, float tamaño)
        {
            float t = tamaño < 10 ? tamaño * 10 : tamaño;
            float centerX = 350, centerY = 150;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            PointF topCenter = new PointF(centerX, centerY - (t * 0.3f));
            PointF bottomPoint = new PointF(centerX, centerY + (t * 0.7f));

            path.AddBezier(topCenter, new PointF(centerX - t, centerY - t), new PointF(centerX - t, centerY + (t * 0.4f)), bottomPoint);
            path.AddBezier(bottomPoint, new PointF(centerX + t, centerY + (t * 0.4f)), new PointF(centerX + t, centerY - t), topCenter);

            g.FillPath(Brushes.Red, path);
            g.DrawPath(new Pen(Color.DarkRed, 2), path);

        
            g.DrawString($"A: {calc.CalcularAreaCorazon(tamaño):F2}", SystemFonts.DefaultFont, Brushes.Black, centerX - 20, centerY + t + 5);
        }

        // --- LUNA ---
        public void DibujarLuna(Graphics g, float radio)
        {
            float r = radio < 10 ? radio * 10 : radio;
            float centerX = 350, centerY = 150;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            RectangleF rectExterior = new RectangleF(centerX - r, centerY - r, r * 2, r * 2);
            RectangleF rectInterior = new RectangleF(centerX - (r * 0.6f), centerY - r, r * 2, r * 2);

            path.AddArc(rectExterior, 90, 180);
            path.AddArc(rectInterior, 270, -180);
            path.CloseFigure();

            g.FillPath(new SolidBrush(Color.FromArgb(190, 215, 110)), path);
            g.DrawPath(new Pen(Color.FromArgb(45, 50, 75), 3), path);

         
            g.DrawString($"A: {calc.CalcularAreaLuna(radio):F2}", SystemFonts.DefaultFont, Brushes.Black, centerX - r, centerY + r + 5);
        }

        // --- CRUZ ---
        public void DibujarCruz(Graphics g, float tamañoBrazo)
        {
            float t = tamañoBrazo < 10 ? tamañoBrazo * 10 : tamañoBrazo;
            float centerX = 350, centerY = 150;
            PointF[] puntos = new PointF[] {
        new PointF(centerX - (t / 2), centerY - (t * 1.5f)), new PointF(centerX + (t / 2), centerY - (t * 1.5f)),
        new PointF(centerX + (t / 2), centerY - (t / 2)),    new PointF(centerX + (t * 1.5f), centerY - (t / 2)),
        new PointF(centerX + (t * 1.5f), centerY + (t / 2)), new PointF(centerX + (t / 2), centerY + (t / 2)),
        new PointF(centerX + (t / 2), centerY + (t * 1.5f)), new PointF(centerX - (t / 2), centerY + (t * 1.5f)),
        new PointF(centerX - (t / 2), centerY + (t / 2)),    new PointF(centerX - (t * 1.5f), centerY + (t / 2)),
        new PointF(centerX - (t * 1.5f), centerY - (t / 2)), new PointF(centerX - (t / 2), centerY - (t / 2))
    };

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(new SolidBrush(Color.FromArgb(40, 160, 220)), puntos);
            g.DrawPolygon(new Pen(Color.FromArgb(40, 50, 70), 3), puntos);

          
            g.DrawString($"A: {calc.CalcularAreaCruz(tamañoBrazo)} P: {calc.CalcularPerimetroCruz(tamañoBrazo)}", SystemFonts.DefaultFont, Brushes.Black, centerX - t, centerY + (t * 1.7f));
        }

        // --- PIE (Gráfico de Tarta) ---
        public void DibujarPie(Graphics g, float radio, float grados)
        {
            float r = radio < 10 ? radio * 10 : radio;
            float centerX = 350, centerY = 150;
            Rectangle rect = new Rectangle((int)(centerX - r), (int)(centerY - r), (int)(r * 2), (int)(r * 2));

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPie(new SolidBrush(Color.FromArgb(180, 160, 130)), rect, 0, grados);
            g.DrawPie(new Pen(Color.FromArgb(60, 55, 80), 3), rect, 0, grados);

        
            g.DrawString($"A: {calc.CalcularAreaPie(radio, grados):F2}", SystemFonts.DefaultFont, Brushes.Black, centerX - r, centerY + r + 5);
        }

        public void DibujarFlecha(Graphics g, float base_cuerpo, float altura_cuerpo, float base_cabeza, float altura_cabeza)
        {
            float x = 350;
            float y = 150;

            // Mitades para centrar
            float mitad_cuerpo = altura_cuerpo / 2;
            float mitad_cabeza = altura_cabeza / 2;

            PointF p1 = new PointF(x, y - mitad_cuerpo);                        
            PointF p2 = new PointF(x + base_cuerpo, y - mitad_cuerpo);          
            PointF p3 = new PointF(x + base_cuerpo, y - mitad_cabeza);       
            PointF p4 = new PointF(x + base_cuerpo + base_cabeza, y);           
            PointF p5 = new PointF(x + base_cuerpo, y + mitad_cabeza);         
            PointF p6 = new PointF(x + base_cuerpo, y + mitad_cuerpo);          
            PointF p7 = new PointF(x, y + mitad_cuerpo);                       

            PointF[] flecha = { p1, p2, p3, p4, p5, p6, p7 };

            g.FillPolygon(Brushes.Yellow, flecha);
            g.DrawPolygon(Pens.Black, flecha); 
        }




    }

    }



