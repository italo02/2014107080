using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class Encomienda : Servicio
    {
        public LugarViaje Origen { get; set; }
        public LugarViaje Destino { get; set; }
        public String AsuntoEncomienda { get; set; }
        public double Peso { get; set; }
        public Bus Bus { get; set; }
        public String NombreDestinatario { get; set; }


        public Encomienda()
        {
            AsuntoEncomienda = String.Empty;
            NombreDestinatario = String.Empty;
            NombreServicio = String.Empty;
            this.NombreServicio = "Servicio de Encomienda";
        }
    }
}
