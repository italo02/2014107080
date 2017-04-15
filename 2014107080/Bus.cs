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
        private int capacidad = 45;

        public int Capacidad
        {
            get
            {
                return capacidad;
            }
        }

        public Bus(int pasajeros)
        {

            Placa = String.Empty;
            SerieMotor = String.Empty;
            ////capacidad máxima de pasajeros 45
            //int calculo = capacidad - (pasajeros + tripulacion.Cantidad);
            //if (calculo < 0)
            //{
            //    Console.WriteLine("Capacidad del bus excedida");
            //}
            //else
            //{
            //    capacidad = calculo;
            //}
        }
    }
}
