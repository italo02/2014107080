using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class Bus
    {
        public String Placa { get; set; }
        public String SerieMotor { get; set; }
        public Tripulacion Tripulacion { get; set; }
       
              
        public Bus()
        {
            Placa = String.Empty;
            SerieMotor = String.Empty;
            
        }
    }
}
