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
    }
}
