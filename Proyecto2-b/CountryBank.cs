namespace SegundoProyecto;

public class CountryBank
{
    //Declaración de propiedades
    public string tipoCuenta { get; set; }
    public string nombreUsuario { get; set; }
    public string numeroDPI { get; set; }
    public string direccionUsuario { get; set; }
    public string numeroTel { get; set; }
    public double saldoActual { get; set; }
    public double abonoCuenta { get; set; }
    public string Servicio { get; set; }

    //Declaración de propiedades para el constructor de historial
    public static DateTime Fecha = DateTime.Now;
    public static double Cantidad { get; set; }
    //Instancia de clase para historial
    Operaciones operaciones = new Operaciones(Fecha, Cantidad,"");
    //Declaración de lista para historial de transacciones
    List<Operaciones> _RegistroOperaciones = new List<Operaciones>();


    //Declaración de constructor Vacío para poder ser llamado sin los parámetros
    public CountryBank() { }
    //Declaración de constructor
    public CountryBank(string tipoCuenta, string nombreUsuario, string numeroDPI, string direccionUsuario, string numeroTel, double saldoActual)
    {
        this.tipoCuenta = tipoCuenta;
        this.nombreUsuario = nombreUsuario;
        this.numeroDPI = numeroDPI;
        this.direccionUsuario = direccionUsuario;
        this.numeroTel = numeroTel;
        this.saldoActual = saldoActual;

    }

    // Método para ingresar datos del usuario
    public void IngresoDatos()
    {

        Console.WriteLine("\n Seleccione el tipo de cuenta a operar \n a. Monetaria en Q \n b. Ahorro en Q \n c. Monetaria en $ \n d. Ahorro en ");
        char opcionCuenta = Console.ReadLine().ToLower()[0];
        switch (opcionCuenta)
        {
            case 'a':
                tipoCuenta = "Monetaria en Q";
                break;
            case 'b':
                tipoCuenta = "Ahorro en Q";
                break;
            case 'c':
                tipoCuenta = "Monetaria en $";
                break;
            case 'd':
                tipoCuenta = "Ahorro en $";
                break;
            default:
                Console.WriteLine(" ");
                break;
        }
        //Validar que sea ingresada el tipo de cuenta para continuar
        if (tipoCuenta == "Monetaria en Q" || tipoCuenta == "Ahorro en Q" || tipoCuenta == "Monetaria en $" || tipoCuenta == "Ahorro en $")
        {
            //Mediante un try catch atrapar cualquier excepción que se presente, como el ingreso de un caracter no string
            try
            {
                Console.WriteLine("\nIngrese el nombre de usuario");
                nombreUsuario = Console.ReadLine();

                Console.WriteLine("\nDigite el número de DPI del usuario (5 caracteres)");
                numeroDPI = Console.ReadLine();

                // Ciclo while de validación
                while (numeroDPI.Length < 5 || numeroDPI.Length > 5)
                {
                    Console.WriteLine("\nEl número del DPI deber ser de 5 caracteres \nDigite el número de DPI del usuario (5 caracteres)");
                    numeroDPI = Console.ReadLine();
                }

                Console.WriteLine("\nIngrese su dirección");
                direccionUsuario = Console.ReadLine();

                Console.WriteLine("\nIngrese su número de teléfono");
                numeroTel = Console.ReadLine();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ocurrió una excepción" + e.Message);
            }

            //Asignación de saldo 
            saldoActual = 2500;
        }
        else
        {
            Console.WriteLine("Su tipo de cuenta no existe");
        }

    }

    // Método para mostrar datos del usuario
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombreUsuario);
        Console.WriteLine("Tipo de cuenta: " + tipoCuenta);
        Console.WriteLine("Número de DPI: " + numeroDPI);
        Console.WriteLine("Dirección: " + direccionUsuario);
        Console.WriteLine("Saldo actual: " + saldoActual.ToString("0.00")); //Utilizar el método .ToString para especificar decimales
    }

    //Declaración de método comprar producto
    public void CompraProducto()
    {
        saldoActual -= (saldoActual * 0.1);
        System.Console.WriteLine("Usted acaba de realizar una compra de producto financiero");
        Console.WriteLine("Saldo actual: " + saldoActual.ToString("0.00"));

        Cantidad = saldoActual;

        //Guardar operación en historial
        var Compra = new Operaciones(Fecha, Cantidad, "Crédito");
        _RegistroOperaciones.Add(Compra);
    }

    // Declaración de método Venta producto 

    public void VentaProducto()
    {
        if (saldoActual > 500)
        {
            saldoActual = saldoActual + (saldoActual * 0.11);
            System.Console.WriteLine("Usted realizó una venta de producto financiero");
            Console.WriteLine("Saldo actual: " + saldoActual.ToString("0.00"));
        }
        else
        {
            double gananciaSaldo = saldoActual / 100;
            Console.WriteLine("Se recomienda no realizar la transacción debido a que el porcentaje de su saldo actual es " + gananciaSaldo.ToString("0.00") + "%");
        }
        //Guardar operación en historial
        Cantidad = saldoActual;
        var Venta = new Operaciones(Fecha, Cantidad, "Débito");
        _RegistroOperaciones.Add(Venta);
    }

    //Declaración de método para abonar a la cuenta

    public void AbonoCuenta()
    {
        Console.WriteLine("");
        if (abonoCuenta < 2 && saldoActual > 500)
        {
            saldoActual = saldoActual * 2;
            abonoCuenta++;
            System.Console.WriteLine("Usted realizó un abono su cuenta personal");
            Console.WriteLine("Saldo actual: {0:N2} " + saldoActual.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("No es posible realizar la operación debido a que no cuenta con los fondos suficientes ");
            System.Console.WriteLine("El saldo debe ser mayor a 500 \n Saldo actual: " + saldoActual.ToString("0.00"));
        }

        //Guardar operación en historial
        var Abono = new Operaciones(Fecha, Cantidad, "Debo");
        _RegistroOperaciones.Add(Abono);

    }

    //Declaracion de metodo para simulador de tiempo
    public void SimuladorTiempo()
    {
        double simulador = 0;
        double suma = 0;
        Console.WriteLine("Simular el paso del tiempo");
        Console.WriteLine("Cúanto tiempo desea simular \n a. 30 días \n b. 15 días");
        char opcionSimulador = Console.ReadLine().ToLower()[0];
        switch (opcionSimulador)
        {
            case 'a':
                simulador = (saldoActual * 0.02 * 30);
                Console.WriteLine("El interés es de: " + simulador.ToString("0.00"));
                suma = (simulador + saldoActual);
                Console.WriteLine("Saldo de cuenta en 30 días: " + suma.ToString("0.00"));
                break;

            case 'b':
                simulador = (saldoActual * 0.02 * 15);
                Console.WriteLine("El interés es de: " + simulador.ToString("0.00"));
                suma = (simulador + saldoActual);
                Console.WriteLine("Saldo de cuenta en 15 días: " + suma.ToString("0.00"));
                break;

            default:
                Console.WriteLine("La opción que escogió, no existe");
                break;
        }
    }

    public void MenuPagoServicios()
    {
        System.Console.WriteLine("Seleccione el servicio que en el que desea realizar un pago");

        //validar mediante un ciclo while
        bool validacionFormularioServicio = false;
        while (validacionFormularioServicio == false)
        {
            System.Console.WriteLine("a. Empresa de agua \nb. Empresa eléctrica \nc. Empresa telefónica");
            char formularioServicio = Console.ReadLine().ToLower()[0];

            //Validación de correcto ingreso de caracteres
            if (formularioServicio == 'a' || formularioServicio == 'b' || formularioServicio == 'c')
            {
                switch (formularioServicio)
                {
                    case 'a':
                        Servicio = "Empresa de agua";
                        break;
                    case 'b':
                        Servicio = "Empresa eléctrica";
                        break;
                    case 'c':
                        Servicio = "Empresa telefónica";
                        break;
                    default:
                        Console.WriteLine(" ");
                        break;
                }
                validacionFormularioServicio = true;
            }
            else
            {
                System.Console.WriteLine("Debe ingresar la opción indicada \nIntente de Nuevo");

            }
        }
        if (Servicio == "Empresa de agua" || Servicio == "Empresa eléctrica" || Servicio == "Empresa telefónica")
        {
            bool ValidacionMonto = false;
            while (ValidacionMonto == false)
            {
                try
                {

                    System.Console.WriteLine("Ingrese el monto para realizar el pago");
                    double monto = Int32.Parse(Console.ReadLine());

                    if (saldoActual - monto < 0)
                    {
                        System.Console.WriteLine("No cuenta con el saldo suficiente para realizar la operación");
                        ValidacionMonto = true;

                    }
                    else
                    {
                        //Asignacion de valores para instanciar clase Operaciones 
                        saldoActual -= monto;
                        Console.WriteLine(saldoActual);
                        Cantidad = monto;
                        Console.WriteLine("Transacción realizada con éxito. Usted acaba de transferir " + monto + " a " + Servicio);

                        var pago = new Operaciones(Fecha, Cantidad, "Debo"); //Instancia para historial de operaciones
                        _RegistroOperaciones.Add(pago);
                        ValidacionMonto = true;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    System.Console.WriteLine("Ocurrió una excepción.\n Debe introducir un valor Real." + ex.Message);
                }

            }

        }
    }

    public string HistorialOperaciones()
    {
        //El System.Text.StringBuilder() permite modificar una cadena sin crear un objeto

        var registro = new System.Text.StringBuilder();

        registro.AppendLine("Fecha\t\t\t\tCantidad\tSaldo"); //Poniendo formato para una mejor visualización
        foreach (var transaccion in _RegistroOperaciones)
        {
            //mostrar el saldo con el que el usuario contaba al realizar la transaccion 
            saldoActual += transaccion.Cantidad;
            //llamar a las variables que requieren los parámetros
            registro.AppendLine($"{transaccion.Fecha}\t{transaccion.Cantidad}\t\t{saldoActual}\t{transaccion.tipoOperacion}"); 
        }
        return registro.ToString();
    }

}
