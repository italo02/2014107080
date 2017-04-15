using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class TipoViaje
    {
        public static int NORMAL = 0;
        public static int VIP = 1;
        public String Nombre { get; }

        public TipoViaje(int i)
        {
            if (i == NORMAL)
            {
                Nombre = "Bus Normal";
            }
            else
            {
                Nombre = "Bus Cama";
            }

        }

    }
}
