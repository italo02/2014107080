using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class Empleado
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String DNI { get; set; }
        public int Edad { get; set; }
        public Decimal Sueldo { get; set; }

        public Empleado(String nombre, String apellidos, String dni, int edad, Decimal sueldo)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            Edad = edad;
            Sueldo = sueldo;
        }

    }
}
