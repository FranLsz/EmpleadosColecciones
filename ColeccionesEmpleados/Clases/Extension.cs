using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEmpleados.Clases
{
    public static class Extension
    {
        // el argumento es el tipo de dato sobre el que se quiere operar
        public static String Sustituye(this String original, String entrada, String salida)
        {
            var cad = original.Replace(entrada, salida);
            return cad;
        }

    }
}
