using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace shappes_2d
{
    /*internal class Calculos
    {
    }*/
    public class Calculos
    {
        public Calculos() { }
        public float CalcularAreaRectangulo(float weight, float height)
        {
            return weight * height;
        }
        public float CalcularPerimetroRectangulo(float weight, float height)
        {
            return 2 * (weight + height);
        }

        public float CalcularPerimetroTriangulo(float ladoA, float ladoB, float ladoC)
        {
            return ladoA + ladoB + ladoC;
        }

        public float CalcularAreaTriangulo(float ladoA, float ladoB, float ladoC)
        {
            float suma = ladoA + ladoB + ladoC;
            return (float)(Math.Sqrt(suma * (suma - ladoA) * (suma - ladoB) * (suma - ladoC)));
        }

        public float CalcularAreaHexagono(float radio)
        {
            return (float)((3 * Math.Sqrt(3) * Math.Pow(radio, 2)) / 2);
        }

        public float CalcularPerimetroHexagono(float radio)
        {
            return 6 * radio;
        }

        public float CalcularAreaCirculo(float radio)
        {
            return (float)(Math.PI * Math.Pow(radio, 2));
        }

        public float CalcularPerimetroCirculo(float radio)
        {
            return (float)(2 * Math.PI * radio);
        }

        public float CalcularAreaElipse(float radioMayor, float radioMenor)
        {
            return (float)(Math.PI * radioMayor * radioMenor);
        }

        public float CalcularPerimetroElipse(float radioMayor, float radioMenor)
        {
            return (float)(Math.PI * (3 * (radioMayor + radioMenor) - Math.Sqrt((3 * radioMayor + radioMenor) * (radioMayor + 3 * radioMenor))));
        }

        public float CalcularAreaOvalo(float radioMayor, float radioMenor)
        {
            return (float)(Math.PI * radioMayor * radioMenor);
        }

        public float CalcularPerimetroOvalo(float radioMayor, float radioMenor)
        {
            return (float)(Math.PI * (3 * (radioMayor + radioMenor) - Math.Sqrt((3 * radioMayor + radioMenor) * (radioMayor + 3 * radioMenor))));
        }

        public float CalcularAreaCuadrado(float lado)
        {
            return lado * lado;
        } 
        
        public float CalcularPerimetroCuadrado(float lado)
        {
            return 4 * lado;
        }

        public float CalcularAreaTrapecio(float baseMayor, float baseMenor, float lado_mayor, float lado_menor)
        {
            float altura = (float)(Math.Sqrt(Math.Pow(lado_mayor, 2) - Math.Pow((baseMayor - baseMenor) / 2, 2)));
            return (baseMayor + baseMenor) * altura / 2;
        }

        public float CalcularPerimetroTrapecio(float baseMayor, float baseMenor, float lado_mayor, float lado_menor)
        {
            return baseMayor + baseMenor + lado_mayor + lado_menor;
        }

        public float CalcularAreaPentagono(float lado)
        {
            return (float)((Math.Pow(lado, 2) * Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4);
        }

        public float CalcularPerimetroPentagono(float lado)
        {
            return 5 * lado;
        }

        public float CalcularAreaHeptagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 7));
            return (float)((7 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 7)));
        }

        public float CalcularPerimetroHeptagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 7));
            return 7 * lado;
        }

        public float CalcularAreaOctagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 8));
            return (float)((2 * Math.Pow(lado, 2)) / Math.Tan(Math.PI / 8));
        }

        public float CalcularPerimetroOctagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 8));
            return 8 * lado;
        }

        public float CalcularAreaNonagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 9));
            return (float)((9 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 9)));
        }

        public float CalcularPerimetroNonagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 9));
            return 9 * lado;
        }

        public float CalcularAreaDecagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 10));
            return (float)((5 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 10)));
        }

        public float CalcularPerimetroDecagono(float radio)
        {
            float lado = (float)(2 * radio * Math.Sin(Math.PI / 10));
            return 10 * lado;
        }

        public float CalcularAreaFlecha(float base_cuerpo, float altura_cuerpo, float base_cabeza, float altura_cabeza)
        {
            float area_cuerpo = base_cuerpo * altura_cuerpo;
            float area_cabeza = (base_cabeza * altura_cabeza) / 2;
            return area_cuerpo + area_cabeza;
        }
      
        public float CalcularAreaParalelogramo(float baseP, float alturaP) => baseP * alturaP;
        public float CalcularPerimetroParalelogramo(float ladoA, float ladoB) => 2 * (ladoA + ladoB);



        public float CalcularAreaTrianguloEquilatero(float lado) => (float)((Math.Sqrt(3) / 4) * lado * lado);
        public float CalcularPerimetroTrianguloEquilatero(float lado) => 3 * lado;



      
        public float CalcularAreaTrianguloEscaleno(float ladoA, float ladoB, float ladoC)
        {
         
            float s = (ladoA + ladoB + ladoC) / 2; 
            float area = (float)Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
            return area;
        }

        public float CalcularPerimetroTrianguloEscaleno(float ladoA, float ladoB, float ladoC)
        {
            return ladoA + ladoB + ladoC;
        }

        public float CalcularAreaTrianguloRectangulo(float baseT, float alturaT)
            => (baseT * alturaT) / 2;

        public float CalcularPerimetroTrianguloRectangulo(float baseT, float alturaT)
        {
            float hipotenusa = (float)Math.Sqrt(Math.Pow(baseT, 2) + Math.Pow(alturaT, 2));
            return baseT + alturaT + hipotenusa;
        }

        public float CalcularAreaRombo(float diagM, float diagm) => (diagM * diagm) / 2;
        public float CalcularPerimetroRombo(float lado) => 4 * lado;

        public float CalcularAreaCometa(float diagonalMayor, float diagonalMenor)
    => (diagonalMayor * diagonalMenor) / 2;

        public float CalcularPerimetroFlecha(float base_cuerpo, float altura_cuerpo, float base_cabeza, float altura_cabeza)
        {
            float perimetro_cuerpo = 2 * (base_cuerpo + altura_cuerpo);
            float perimetro_cabeza = base_cabeza + 2*(float)(Math.Sqrt(Math.Pow(base_cabeza/2, 2) + Math.Pow(altura_cabeza, 2)));
            return perimetro_cuerpo + perimetro_cabeza - altura_cuerpo;
        }
    }
}
