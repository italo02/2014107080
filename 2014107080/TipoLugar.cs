using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class TipoLugar
    {
        public static int DESTINO = 0;
        public static int ORIGEN = 1;
        public String NombreTipo { set; get; }

        public TipoLugar(int i)
        {
            if (i == DESTINO)
            {
                NombreTipo = "Origen";
            }
            else
            {
                NombreTipo = "Destino";
            }
            NombreTipo = String.Empty;
        }
    }
}
