using System;

namespace Proyecto1
{
    public class ProgramaFinanciero
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Bienvenido al Banco Country Bank");
            Console.WriteLine("Ingrese su información");
            Console.WriteLine($"Ingrese su tipo de cuenta \n a. Monetaria en Q \n b. Ahorro en Q \n c. Monetaria en $ \n d. Ahorro en $");
            string TC = "";
            char tipocuenta = Console.ReadLine().ToLower()[0];
            switch (tipocuenta)
            {
                case 'a':
                    TC = "Monetaria en Q";
                break;
                case 'b':
                    TC = "Ahorro en Q";
                break;
                case 'c':
                    TC = "Monetaria en $";
                break;
                case 'd':
                    TC = "Ahorro en $";
                break;
                default:
                    Console.WriteLine("La opción no es válida");
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su DPI (5 caracteres)");
            string DPI = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su dirección");
            string direccion = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su número de teléfono");
            string ntel = Console.ReadLine();
            double tcuenta = 2500.00;

            Console.ReadKey();
            string InfoCuenta = $"Su información de cuenta\n Tipo de cuenta: {TC}\n Nombre: {nombre}\n DPI: {DPI}\n Dirección: {direccion}\n Número de telfono: {ntel}\n Saldo: {tcuenta}";
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(InfoCuenta);
            bool Salir = false;
            do
            {
                Console.WriteLine(" A continuación, seleccione el número de la opción que desea ejecutar");
                Console.WriteLine("1. Ingresar a cuenta");
                Console.WriteLine("2. Comprar Producto");
                Console.WriteLine("3. Vender Producto");
                Console.WriteLine("4. Abonar a cuenta");
                Console.WriteLine("5. Simular paso del tiempo");
                Console.WriteLine("6. Salir");
                string opciones = Console.ReadLine();
                switch (opciones)
                {
                    case "1":
                        {

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Su saldo actual es " + ComprarProducto(tcuenta));
                            break;
                        }
                    case "3":
                        {   
                            Console.WriteLine("Su saldo actual es " + VenderProducto(tcuenta));
                            break;
                        }
                    case "4":
                        {

                            break;
                        }
                    case "5":
                        {

                            break;
                        }
                    case "6":
                        {
                            Salir = true;
                            Console.WriteLine("Gracias por utilizar nuestros servicios");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción no valida, seleccionar otra opción");
                            break;
                        }
                }
            }
            while (!Salir);
            
        }
        public static double ComprarProducto(double tcuenta)
        {
            
            double saldoActual = tcuenta - (tcuenta * 0.1);
            tcuenta = saldoActual;

            return tcuenta;
        }
        public static double VenderProducto(double tcuenta)
        {
            if (tcuenta > 500)
            {
                double saldoActual = tcuenta + (tcuenta * 0.11);
                tcuenta = saldoActual;
                return tcuenta;
            }
            else
            {
                double g = tcuenta/100;
                Console.WriteLine("Se recomienda no realizar la transacción debido a que el porcentaje de su saldo actual es " + g + "%");
                return g;
            }
            
        }

    }
}