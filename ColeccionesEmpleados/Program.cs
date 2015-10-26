using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeccionesEmpleados.Clases;

namespace ColeccionesEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            int input = 3;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1- Nuevo empleado");
                Console.WriteLine("2- Listado de empleados");
                Console.WriteLine("3- Salir");
                Int32.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        Console.WriteLine("---------");
                        Console.WriteLine("Nuevo empleado:");

                        Console.WriteLine("Nombre: ");
                        var nombre = Console.ReadLine();
                        Console.WriteLine("--");
                        Console.WriteLine("Edad: ");
                        var edad = 0;
                        Int32.TryParse(Console.ReadLine(), out edad);

                        Console.WriteLine("--");
                        Console.WriteLine("Estudios: ");
                        Console.WriteLine("-Basico");
                        Console.WriteLine("-Medio");
                        Console.WriteLine("-Superior");
                        Console.WriteLine("-Doctor");
                        var estudios = Console.ReadLine();
                        Estudios estudiosEnum;
                        Enum.TryParse(estudios, out estudiosEnum);

                        Console.WriteLine("--");
                        Console.WriteLine("Puesto: ");
                        Console.WriteLine("-Programador");
                        Console.WriteLine("-Analista");
                        Console.WriteLine("-DirectorProyectos");
                        Console.WriteLine("-DirectorIT");
                        var puesto = Console.ReadLine();
                        Puestos puestoEnum;
                        Enum.TryParse(puesto, out puestoEnum);

                        try
                        {
                            empleados.Add(new Empleado() { Nombre = nombre, Edad = edad, Estudio = estudiosEnum, Puesto = puestoEnum });
                            Console.WriteLine("\n EMPLEADO AÑADIDO CORRECTAMENTE");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine("---------");
                        break;
                    case 2:
                        Console.WriteLine("---------");
                        Console.WriteLine("Listado de empleados: ");
                        if (empleados.Count > 0)
                        {
                            foreach (var e in empleados)
                            {
                                Console.WriteLine(e);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay empleados para mostrar");
                        }

                        Console.WriteLine("---------");
                        break;
                }


            } while (input != 3);
            Console.WriteLine("");


        }
    }
}
