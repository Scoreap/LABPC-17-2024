namespace SegundoProyecto;

public class CuentasExternas
{
    //Declarar propiedades de la clase
    public int IndiceCuentas = 1;
    public string IndiceUsuario { get; set; }
    public string nombreCuentahabiente { get; set; }
    public string bancoCuentahabiente { get; set; }
    public string numeroCuentahabiente { get; set; }
    List<string[]> _CrearCuenta = new List<string[]>();

    public CuentasExternas() { }

    public CuentasExternas(string nombreCuentahabiente, string bancoCuentahabiente, string numeroCuentahabiente, int agregarCuenta)
    {
        this.nombreCuentahabiente = nombreCuentahabiente;
        this.bancoCuentahabiente = bancoCuentahabiente;
        this.numeroCuentahabiente = numeroCuentahabiente;
    }

//Método con parámetros
    public void CuentaNueva(string nombreCuentahabiente, string numeroCuentahabiente, string bancoCuentahabiente)
    {
        _CrearCuenta.Add(new string[] { IndiceCuentas.ToString(), nombreCuentahabiente, numeroCuentahabiente, bancoCuentahabiente });
        IndiceCuentas++;
    }

    public void RegistroCuentas()
    {
        foreach (var item in _CrearCuenta)
        {
            System.Console.WriteLine("No. " + item[0]);
            System.Console.WriteLine("Nombre: " + item[1]);
            System.Console.WriteLine("Número de cuenta: " + item[2]);
            System.Console.WriteLine("Banco: " + item[3] + "\n");
            IndiceCuentas++;
        }
    }

    public void EliminarCuenta(string IndiceUsuario)
    {

        foreach (var item in _CrearCuenta)
        {
            if (IndiceUsuario == item[0])
            {
                _CrearCuenta.Remove(new string[] { IndiceCuentas.ToString(), nombreCuentahabiente, numeroCuentahabiente, bancoCuentahabiente });
            }

        }
    }
    public void ModificarNombreCuenta(string IndiceUsuario)
    {
        foreach (var item in _CrearCuenta)
        {
            if (IndiceUsuario == item[0])
            {
                if (IndiceUsuario == item[1])
                {
                    _CrearCuenta.RemoveAt(1);
                    _CrearCuenta.Insert(1, new string[] { nombreCuentahabiente });

                }
            }
        }
    }
    public void ModificarNumeroCuenta(string IndiceUsuario)
    {
        foreach (var item in _CrearCuenta)
        {
            if (IndiceUsuario == item[0])
            {
                if (IndiceUsuario == item[2])
                {
                    _CrearCuenta.RemoveAt(2);
                    System.Console.WriteLine("Ingrese el nuevo número para la cuenta" + item[0]);
                    numeroCuentahabiente = Console.ReadLine();
                    _CrearCuenta.Insert(2, new string[] { numeroCuentahabiente });

                }
            }
        }

    }

    public void ModificarNombreBanco(string IndiceUsuario)
    {
        foreach (var item in _CrearCuenta)
        {
            if (IndiceUsuario == item[0])
            {
                if (IndiceUsuario == item[3])
                {
                    _CrearCuenta.RemoveAt(3);
                    System.Console.WriteLine("Ingrese el nuevo nombre del banco de la cuenta" + item[0]);
                    bancoCuentahabiente = Console.ReadLine();
                    _CrearCuenta.Insert(2, new string[] { bancoCuentahabiente });

                }
            }

        }
    }
}

