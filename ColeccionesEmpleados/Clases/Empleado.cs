using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEmpleados.Clases
{
    public enum Estudios
    {
        Basico,
        Medio,
        Superior,
        Doctor,
    };
    public enum Puestos
    {
        Programador,
        Analista,
        DirectorProyectos,
        DirectorIT,
    };

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Estudios Estudio { get; set; }


        private Puestos _puesto;
        public Puestos Puesto
        {
            get { return _puesto; }
            set
            {
                if ((int)value <= (int)Estudio)
                    _puesto = value;
                else
                    throw new EmpleadoPuestoError(
                        "Este empleado no tiene suficientes estudios para el puesto solicitado");
            }
        }

        public override string ToString()
        {
            return $"---\n{Nombre}, {Edad} años. \nNivel de estudios: {Estudio}\nPuesto de trabajo: {Puesto}\n---";
        }
    }
}
