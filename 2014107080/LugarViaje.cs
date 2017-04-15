using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class LugarViaje
    {

        public TipoLugar TipoLugar { get; set; }
        public String NombreLugar { get; set; }

        public LugarViaje(int i)
        {
            TipoLugar = new TipoLugar(i);

            NombreLugar = String.Empty;
        }
    }
}
