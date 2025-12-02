using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2AppEscritorio.Clases
{
    public class clsOpcion3
    {
        public int Suma (int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 + numero2;
            return resultado;
        }

        public int Resta(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 - numero2;
            return resultado;
        }

        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 * numero2;
            return resultado;
        }
    }
}
