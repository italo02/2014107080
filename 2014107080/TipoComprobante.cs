using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class TipoComprobante
    {
        public static int BOLETA = 0;
        public static int FACTURA = 1;
        public String NombreComprobante { get; }

        public TipoComprobante(int i)
        {
            if (i == BOLETA)
            {
                NombreComprobante = "Boleta";
            }
            else
            {
                NombreComprobante = "Factura";
            }
        }
    }
}
