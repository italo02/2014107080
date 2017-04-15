using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class TipoPago
    {
        public static int EFECTIVO = 0;
        public static int TARJETA = 1;
        public static int DEPOSITO = 2;
        public String MetodoPago { get; }

        public TipoPago(int i)
        {
            switch (i)
            {
                case 0:
                    MetodoPago = "Efectivo";
                    break;
                case 1:
                    MetodoPago = "Tarjeta de crédito";
                    break;
                case 2:
                    MetodoPago = "Depósito Bancario";
                    break;
            }
        }
    }
}
