using SegundoProyecto;

/*

Sophia Alejandra Corea Perdomo 1185324

*/

class Programa
{
    //Llamar Clases utilizadas
    static CountryBank Banco = new CountryBank();
    static CuentasExternas CuentasExternas = new CuentasExternas();
    static Transacciones transacciones = new Transacciones();

    static void Main(string[] args)
    {
        //Llamar método de menú 
        Entrada();
    }
//Declaración del método menú
    static void Entrada()
    {

        bool Salir = true;

        // Selección de tipo de cuenta
        Console.WriteLine("Bienvenido a la banca virtual del Banco Country Bank \n A contiuación, ingrese la información solicitada.");
        Banco.IngresoDatos();

        do
        {
            Console.WriteLine("\nSeleccione el número de la opción que desea ejecutar");
            Console.WriteLine("1.  Ver información de cuenta");
            Console.WriteLine("2.  Comprar Producto");
            Console.WriteLine("3.  Vender Producto");
            Console.WriteLine("4.  Abonar a cuenta");
            Console.WriteLine("5.  Simular paso del tiempo");
            Console.WriteLine("6.  Mantenimiento de cuentas");
            Console.WriteLine("7.  Realizar transferencia");
            Console.WriteLine("8.  Pagar Servicio");
            Console.WriteLine("9.  Mostrar registro de operaciones");
            Console.WriteLine("10. Salir");
            string opciones = Console.ReadLine();
            //Menú de opciones
            switch (opciones)
            {
                case "1":
                    {
                        Banco.MostrarDatos();
                        break;
                    }
                case "2":
                    {
                        Banco.CompraProducto();
                        break;
                    }
                case "3":
                    {
                        Banco.VentaProducto();
                        break;
                    }
                case "4":
                    {
                        Banco.AbonoCuenta();
                        break;
                    }
                case "5":
                    {
                        Banco.SimuladorTiempo();
                        break;
                    }
                case "6":
                    {
                        MantenimientoCuentas();
                        break;
                    }
                case "7":
                    {

                        break;

                    }
                case "8":
                    {
                        Banco.MenuPagoServicios();
                        break;

                    }
                case "9":
                    {
                        Console.WriteLine(Banco.HistorialOperaciones());
                        break;

                    }
                case "10":
                    {
                        Salir = false;
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
        while (Salir);
    }

    //Declaración del método mantenimiento de cuentas
    static void MantenimientoCuentas()
    {
        System.Console.WriteLine("Ingrese la información solicitada");
        System.Console.WriteLine("a. Añadir cuenta \nb. Eliminar cuenta \nc. Modificar cuenta \nd. Mostrar registro de cuentas");

        char formularioCuentaNueva = Console.ReadLine().ToLower()[0];
        switch (formularioCuentaNueva)
        {
            case 'a':
                //Validación mediante ciclo do - while 
                bool a_validacionDatos = false;
                do
                {
                    System.Console.WriteLine("Ingrese el nombre de la nueva cuenta");
                    string nombreCuentahabiente = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el número de la cuenta");
                    string numeroCuentahabiente = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el nombre del banco al que pertenece");
                    string bancoCuentahabiente = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombreCuentahabiente) || string.IsNullOrWhiteSpace(numeroCuentahabiente) || string.IsNullOrWhiteSpace(bancoCuentahabiente))
                    {

                        System.Console.WriteLine("Los campos son obligatorios");

                    }
                    else
                    {
                        CuentasExternas.CuentaNueva(nombreCuentahabiente, numeroCuentahabiente, bancoCuentahabiente);
                        System.Console.WriteLine("Cuenta creada exitósamente \n");
                        a_validacionDatos = true;
                    }

                }
                while (!a_validacionDatos);
                break;

            case 'b':
                CuentasExternas.RegistroCuentas();
                bool b_validacionDatos = false;
                do
                {
                    System.Console.WriteLine("Ingrese el número de la cuenta que desea eliminar");
                    string IndiceBorrarCuenta = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(IndiceBorrarCuenta))
                    {

                        System.Console.WriteLine("Debe ingresar un número");

                    }
                    else
                    {
                        CuentasExternas.EliminarCuenta(IndiceBorrarCuenta);

                        System.Console.WriteLine("Cuenta borrada exitósamente \n");
                        b_validacionDatos = true;
                    }

                }
                while (!b_validacionDatos);

                break;
            case 'c':
                CuentasExternas.RegistroCuentas();
                bool c_validacionDatos = false;
                do
                {
                    System.Console.WriteLine("Ingrese el número de cuenta que desea modificar");
                    string IndiceModificarCuenta = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(IndiceModificarCuenta))
                    {

                        System.Console.WriteLine("Debe ingresar un número");

                    }
                    else
                    {
                        System.Console.WriteLine("Ingrese la opción del dato que desea modificar");
                        System.Console.WriteLine("1. Cambiar nombre \n2.Modificar número de cuenta \n.3. Modificar nombre de Banco");
                        string ModificarDato = Console.ReadLine();
                        if (ModificarDato == "1")
                        {
                            System.Console.WriteLine("Ingrese el nuevo nombre para la cuenta");
                            string nombreCuentahabiente = Console.ReadLine();
                            CuentasExternas.ModificarNombreCuenta(ModificarDato);
                            c_validacionDatos = true;
                        }
                        if (ModificarDato == "2")
                        {
                            System.Console.WriteLine("Ingrese el nuevo número para la cuenta");
                            string numeroCuentahabiente = Console.ReadLine();
                            CuentasExternas.ModificarNumeroCuenta(ModificarDato);
                            c_validacionDatos = true;
                        }
                        if (ModificarDato == "3")
                        {
                            System.Console.WriteLine("Ingrese el nuevo nombre del banco de la cuenta");
                            string bancoCuentahabiente = Console.ReadLine();
                            CuentasExternas.ModificarNombreBanco(ModificarDato);
                            c_validacionDatos = true;
                        }

                        System.Console.WriteLine("¡Cuenta modificada con éxito! \nPuede visualizarla en el apartado de 'Registro de cuentas' ");
                        c_validacionDatos = true;
                    }

                }
                while (!c_validacionDatos);
                break;
            case 'd':
                System.Console.WriteLine("Cuentas Registradas en Banco Countrybank");
                CuentasExternas.RegistroCuentas();
                break;
            default:
                Console.WriteLine(" ");
                break;
        }

    }


}
