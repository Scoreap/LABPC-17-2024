namespace SegundoProyecto;
class Transacciones
{
    public DateTime Fecha { get; set; }
    public double Cantidad { get; set; }
    List<string[]> _Transferencia = new List<string[]>();
    List<string[]> _CrearCuenta = new List<string[]>();

    public Transacciones(){}

    public Transacciones(DateTime fecha, double cantidad)
    {
        this.Fecha = Fecha;
        this.Cantidad = Cantidad;
    }

    public void NuevaTransaccion()
    {
        _Transferencia.Add(new string[] { Fecha.ToString(), Cantidad.ToString(),  });

    }
    

}