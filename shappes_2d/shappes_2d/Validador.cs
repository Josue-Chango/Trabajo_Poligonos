using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shappes_2d
{
    /*internal class Validador
    {
    }*/
    public static class Validador
    {
        public static bool Validar<T>(string texto)
        {
            // validar vacío o espacios
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            if (texto.Contains(" "))
                return false;

            // validar según el tipo
            if (typeof(T) == typeof(int))
            {
                int num;
                if (!int.TryParse(texto, out num) || num < 0)
                    return false;
            }
            else if (typeof(T) == typeof(float))
            {
                float num;
                if (!float.TryParse(texto, out num) || num < 0)
                    return false;
            }
            else if (typeof(T) == typeof(double))
            {
                double num;
                if (!double.TryParse(texto, out num) || num < 0)
                    return false;
            }
            else if (typeof(T) == typeof(string))
            {
                return true;
            }
            else
            {
                return false;
            }

            return true;
        }

        public static bool ValidarTriangulo(float ladoA, float ladoB, float ladoC)
        {
            if (ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA)
                return false;
            return true;
        }

        public static bool ValidarTrapecio(float lado_izquierdo, float lado_derecho, float base_mayor, float base_menor)
        {
            
            if (base_mayor <= base_menor)
                return false;

            float diferencia = base_mayor - base_menor;
            float dx_li = (diferencia * diferencia + lado_izquierdo * lado_izquierdo - lado_derecho * lado_derecho)
                          / (2 * diferencia);

            float h2 = lado_izquierdo * lado_izquierdo - dx_li * dx_li;
            if (h2 <= 0)
                return false;

            return true;
        }
    }
}
