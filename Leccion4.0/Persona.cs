using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion4._0
{
    public class Persona : Operaciones
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public bool esMayorDeEdad()
        {
            return Edad >= 18;
        }

        public string imprimirInfo()
        {
            return $"\nNombre: {Nombre}, Apellido: {Apellido}, Edad: {Edad}";
        }

        

    }
}
