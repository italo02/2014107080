using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014107080
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var administrativo = "Juan";
            var apellidosadministrativo = "Smith";
            var DNIadministrativo = "1234567";
            var sueldoadministrativo = 2500m;
            var cargo = "Recepcionista";
            var edadadministrativo = 35;

            var tripulante1 = "Pedro";
            var DNItripulante1 = "1234568";
            var edadtripulante1 = 36;
            var apellidotripulante1 = "Perez";
            var sueldotripulante1 = 1500m;

            var tripulante2 = "Elisa";
            var DNItripulante2 = "1234569";
            var edadtripulante2 = 37;
            var apellidotripulante2 = "Martinez";
            var sueldotripulante2 = 1500m;

            var tripulante3 = "Eduardo";
            var DNItripulante3 = "1234570";
            var edadtripulante3 = 38;
            var apellidotripulante3 = "Ramirez";
            var sueldotripulante3 = 1500m;


            var cliente1 = "Carlos";
            var apellidoscliente1 = "Garcia";
            var DNIcliente1 = "1234571";

            var cliente2 = "Maria";
            var apellidoscliente2 = "Zarate";
            var DNIcliente2 = "1234573";

            var cliente3 = "Kemy";
            var apellidoscliente3 = "Tangoa";
            var DNIcliente3 = "1234574";

            var cliente4 = "Cesar";
            var apellidoscliente4 = "Marin";
            var DNIcliente4 = "1234575";

            var cliente5 = "Kael";
            var apellidoscliente5 = "Sanchez";
            var DNIcliente5 = "1234576";

            var lugar1 = "Lima";
            var lugar2 = "Ica";

            var seriemotor1 = "AH-4HK1XYBW-01";
            var placa1 = "AEF-717";

            var asunto1 = "Encomienda 1";
            var asunto2 = "Encomienda 2";

            var nombredestinatario1 = "Luis";
            var nombredestinatario2 = "Fernanda";

            var peso1 = 5;
            var peso2 = 7.3;

            var numerocomprobante1 = 1;
            var numerocomprobante2 = 2;
            var numerocomprobante3 = 3;
            var numerocomprobante4 = 4;
            var numerocomprobante5 = 5;

            Decimal tarifa1 = 20m;
            Decimal tarifa2 = 35m;
            Decimal tarifa3 = 50m;
            Decimal tarifa4 = 18m;
            Decimal tarifa5 = 16m;

            Cliente Cliente1 = new Cliente();

            Cliente1.Nombre = cliente1;
            Cliente1.DNI = DNIcliente1;
            Cliente1.Apellidos = apellidoscliente1;

            Tripulacion tripulacion1 = new Tripulacion(tripulante1, apellidotripulante1, DNItripulante1,
                                                        edadtripulante1, 1, TipoTripulacion.CONDUCTOR, sueldotripulante1);

            LugarViaje LugarOrigen1 = new LugarViaje(TipoLugar.ORIGEN);
            LugarViaje LugarDestino1 = new LugarViaje(TipoLugar.DESTINO);
            LugarOrigen1.NombreLugar = lugar1;
            LugarDestino1.NombreLugar = lugar2;

            Bus Bus1 = new Bus(1);

            Bus1.Placa = placa1;
            Bus1.SerieMotor = seriemotor1;
            Bus1.Tripulacion = tripulacion1;

            Transporte servicio1 = new Transporte(TipoViaje.NORMAL, 1, tripulacion1);

            servicio1.Tarifa = tarifa1;
            servicio1.Origen = LugarOrigen1;
            servicio1.Destino = LugarDestino1;
            servicio1.Cliente = Cliente1;
            servicio1.Bus = Bus1;


            Administrativo Administrativo1 = new Administrativo(administrativo, apellidosadministrativo,
                                            DNIadministrativo, edadadministrativo, sueldoadministrativo);
            Administrativo1.Cargo = cargo;

            Venta venta1 = new Venta(TipoComprobante.BOLETA, TipoPago.EFECTIVO);


            venta1.Servicio = servicio1;
            venta1.Administrativo = Administrativo1;
            venta1.Cliente = Cliente1;
            venta1.NumeroComprobante = numerocomprobante1;

            Console.WriteLine("\nNúmero de Comprobante : " + venta1.NumeroComprobante +
                "\nEmpleado: " + venta1.Administrativo.Nombre + " con el cargo de " + venta1.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta1.Servicio.NombreServicio +
                "\nTripulantes: " + servicio1.Bus.Tripulacion.Nombre + " con el cargo de " + servicio1.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio1.Bus.Placa +
                "\nCategoria del Servicio : " + servicio1.TipoViaje.Nombre +
                "\nMonto: " + venta1.Servicio.Tarifa +
                "\nTipo de Pago: " + venta1.TipoPago.MetodoPago +
                "\nLugar de Origen : " + servicio1.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio1.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta1.Cliente.Nombre + " " + venta1.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta1.Cliente.DNI +
                "\nFecha del Servicio: " + venta1.Fecha);



            Cliente Cliente2 = new Cliente();

            Cliente2.Nombre = cliente2;
            Cliente2.DNI = DNIcliente2;
            Cliente2.Apellidos = apellidoscliente2;

            Tripulacion tripulacion2 = new Tripulacion(tripulante2, apellidotripulante2, DNItripulante2,
                                                        edadtripulante2, 1, TipoTripulacion.AZAFATA, sueldotripulante2);

            LugarViaje LugarOrigen2 = new LugarViaje(TipoLugar.ORIGEN);
            LugarViaje LugarDestino2 = new LugarViaje(TipoLugar.DESTINO);
            LugarOrigen2.NombreLugar = lugar1;
            LugarDestino2.NombreLugar = lugar2;

            Bus Bus2 = new Bus(1);

            Bus2.Placa = placa1;
            Bus2.SerieMotor = seriemotor1;
            Bus2.Tripulacion = tripulacion2;

            Transporte servicio2 = new Transporte(TipoViaje.VIP, 1, tripulacion2);

            servicio2.Tarifa = tarifa2;
            servicio2.Origen = LugarOrigen2;
            servicio2.Destino = LugarDestino2;
            servicio2.Cliente = Cliente2;
            servicio2.Bus = Bus2;


            Administrativo Administrativo2 = new Administrativo(administrativo, apellidosadministrativo,
                                            DNIadministrativo, edadadministrativo, sueldoadministrativo);
            Administrativo2.Cargo = cargo;

            Venta venta2 = new Venta(TipoComprobante.BOLETA, TipoPago.TARJETA);


            venta2.Servicio = servicio2;
            venta2.Administrativo = Administrativo2;
            venta2.Cliente = Cliente2;
            venta2.NumeroComprobante = numerocomprobante2;

            Console.WriteLine("\nNúmero de Comprobante : " + venta2.NumeroComprobante +
                "\nEmpleado: " + venta2.Administrativo.Nombre + " con el cargo de " + venta2.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta2.Servicio.NombreServicio +
                "\nTripulantes: " + servicio2.Bus.Tripulacion.Nombre + " con el cargo de " + servicio2.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio2.Bus.Placa +
                "\nCategoria del Servicio : " + servicio2.TipoViaje.Nombre +
                "\nMonto: " + venta2.Servicio.Tarifa +
                "\nTipo de Pago: " + venta2.TipoPago.MetodoPago +
                "\nLugar de Origen : " + servicio2.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio2.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta2.Cliente.Nombre + " " + venta2.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta2.Cliente.DNI +
                "\nFecha del Servicio: " + venta2.Fecha);


            Cliente Cliente3 = new Cliente();

            Cliente3.Nombre = cliente3;
            Cliente3.DNI = DNIcliente3;
            Cliente3.Apellidos = apellidoscliente3;

            Tripulacion tripulacion3 = new Tripulacion(tripulante3, apellidotripulante3, DNItripulante3,
                                                        edadtripulante3, 1, TipoTripulacion.CONDUCTOR, sueldotripulante3);

            LugarViaje LugarOrigen3 = new LugarViaje(TipoLugar.ORIGEN);
            LugarViaje LugarDestino3 = new LugarViaje(TipoLugar.DESTINO);
            LugarOrigen3.NombreLugar = lugar1;
            LugarDestino3.NombreLugar = lugar2;

            Bus Bus3 = new Bus(1);

            Bus3.Placa = placa1;
            Bus3.SerieMotor = seriemotor1;
            Bus3.Tripulacion = tripulacion3;

            Transporte servicio3 = new Transporte(TipoViaje.NORMAL, 1, tripulacion3);

            servicio3.Tarifa = tarifa3;
            servicio3.Origen = LugarOrigen3;
            servicio3.Destino = LugarDestino3;
            servicio3.Cliente = Cliente3;
            servicio3.Bus = Bus3;


            Administrativo Administrativo3 = new Administrativo(administrativo, apellidosadministrativo,
                                            DNIadministrativo, edadadministrativo, sueldoadministrativo);
            Administrativo3.Cargo = cargo;

            Venta venta3 = new Venta(TipoComprobante.FACTURA, TipoPago.TARJETA);


            venta3.Servicio = servicio3;
            venta3.Administrativo = Administrativo3;
            venta3.Cliente = Cliente3;
            venta3.NumeroComprobante = numerocomprobante3;

            Console.WriteLine("\nNúmero de Comprobante : " + venta3.NumeroComprobante +
                "\nEmpleado: " + venta3.Administrativo.Nombre + " con el cargo de " + venta3.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta3.Servicio.NombreServicio +
                "\nTripulantes: " + servicio3.Bus.Tripulacion.Nombre + " con el cargo de " + servicio3.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio3.Bus.Placa +
                "\nCategoria del Servicio : " + servicio3.TipoViaje.Nombre +
                "\nMonto: " + venta3.Servicio.Tarifa +
                "\nTipo de Pago: " + venta3.TipoPago.MetodoPago +
                "\nLugar de Origen : " + servicio3.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio3.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta3.Cliente.Nombre + " " + venta3.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta3.Cliente.DNI +
                "\nFecha del Servicio: " + venta3.Fecha);

            Cliente Cliente4 = new Cliente();

            Cliente4.Nombre = cliente4;
            Cliente4.DNI = DNIcliente4;
            Cliente4.Apellidos = apellidoscliente4;

            Tripulacion tripulacion4 = new Tripulacion(tripulante1, apellidotripulante1, DNItripulante1,
                                                        edadtripulante1, 1, TipoTripulacion.CONDUCTOR, sueldotripulante1);

            LugarViaje LugarOrigen4 = new LugarViaje(TipoLugar.ORIGEN);
            LugarViaje LugarDestino4 = new LugarViaje(TipoLugar.DESTINO);
            LugarOrigen4.NombreLugar = lugar1;
            LugarDestino4.NombreLugar = lugar2;

            Bus Bus4 = new Bus(1);

            Bus4.Placa = placa1;
            Bus4.SerieMotor = seriemotor1;
            Bus4.Tripulacion = tripulacion4;

            Encomienda servicio4 = new Encomienda();

            servicio4.Tarifa = tarifa4;
            servicio4.Origen = LugarOrigen4;
            servicio4.Destino = LugarDestino4;
            servicio4.NombreDestinatario = nombredestinatario1;
            servicio4.Peso = peso1;
            servicio4.Bus = Bus4;


            Administrativo Administrativo4 = new Administrativo(administrativo, apellidosadministrativo,
                                            DNIadministrativo, edadadministrativo, sueldoadministrativo);
            Administrativo4.Cargo = cargo;

            Venta venta4 = new Venta(TipoComprobante.BOLETA, TipoPago.EFECTIVO);


            venta4.Servicio = servicio4;
            venta4.Administrativo = Administrativo4;
            venta4.Cliente = Cliente4;
            venta4.NumeroComprobante = numerocomprobante4;

            Console.WriteLine("\nNúmero de Comprobante : " + venta4.NumeroComprobante +
                "\nEmpleado: " + venta4.Administrativo.Nombre + " con el cargo de " + venta4.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta4.Servicio.NombreServicio +
                "\nTripulantes: " + servicio4.Bus.Tripulacion.Nombre + " con el cargo de " + servicio4.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio4.Bus.Placa +
                "\nMonto: " + venta4.Servicio.Tarifa +
                "\nTipo de Pago: " + venta4.TipoPago.MetodoPago +
                "\nLugar de Origen : " + servicio4.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio4.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta4.Cliente.Nombre + " " + venta4.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta4.Cliente.DNI +
                "\nFecha del Servicio: " + venta4.Fecha);

            Cliente Cliente5 = new Cliente();

            Cliente5.Nombre = cliente5;
            Cliente5.DNI = DNIcliente5;
            Cliente5.Apellidos = apellidoscliente5;

            Tripulacion tripulacion5 = new Tripulacion(tripulante3, apellidotripulante3, DNItripulante3,
                                                        edadtripulante3, 1, TipoTripulacion.CONDUCTOR, sueldotripulante3);

            LugarViaje LugarOrigen5 = new LugarViaje(TipoLugar.ORIGEN);
            LugarViaje LugarDestino5 = new LugarViaje(TipoLugar.DESTINO);
            LugarOrigen5.NombreLugar = lugar1;
            LugarDestino5.NombreLugar = lugar2;

            Bus Bus5 = new Bus(1);

            Bus5.Placa = placa1;
            Bus5.SerieMotor = seriemotor1;
            Bus5.Tripulacion = tripulacion5;

            Encomienda servicio5 = new Encomienda();

            servicio5.Tarifa = tarifa5;
            servicio5.Origen = LugarOrigen5;
            servicio5.Destino = LugarDestino5;
            servicio5.NombreDestinatario = nombredestinatario2;
            servicio5.Peso = peso2;
            servicio5.Bus = Bus5;


            Administrativo Administrativo5 = new Administrativo(administrativo, apellidosadministrativo,
                                            DNIadministrativo, edadadministrativo, sueldoadministrativo);
            Administrativo5.Cargo = cargo;

            Venta venta5 = new Venta(TipoComprobante.BOLETA, TipoPago.DEPOSITO);


            venta5.Servicio = servicio5;
            venta5.Administrativo = Administrativo5;
            venta5.Cliente = Cliente5;
            venta5.NumeroComprobante = numerocomprobante5;

            Console.WriteLine("\nNúmero de Comprobante : " + venta5.NumeroComprobante +
                "\nEmpleado: " + venta5.Administrativo.Nombre + " con el cargo de " + venta5.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta5.Servicio.NombreServicio +
                "\nTripulantes: " + servicio5.Bus.Tripulacion.Nombre + " con el cargo de " + servicio5.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio5.Bus.Placa +
                "\nMonto: " + venta5.Servicio.Tarifa +
                "\nTipo de Pago: " + venta5.TipoPago.MetodoPago +
                "\nLugar de Origen : " + servicio5.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio5.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta5.Cliente.Nombre + " " + venta5.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta5.Cliente.DNI +
                "\nFecha del Servicio: " + venta5.Fecha);



            Console.ReadKey();
        }
    }
}
