using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class Administrativo : Empleado
    {
        public String Cargo { get; set; }
        public Administrativo(String nombre, String apellidos, String dni, int edad, Decimal sueldo) : base(nombre, apellidos, dni, edad, sueldo)
        {
            Cargo = String.Empty;
        }
    }
}