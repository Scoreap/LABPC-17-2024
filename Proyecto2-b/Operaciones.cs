namespace SegundoProyecto;

public class Operaciones //Clase para historial de transacciones
{
    public DateTime Fecha { get; }
    public double Cantidad { get; }
    public string tipoOperacion {get;}

    public Operaciones(DateTime Fecha, double Cantidad, string tipoOperacion)
    {
        this.Fecha = Fecha;
        this.Cantidad = Cantidad;
        this.tipoOperacion = tipoOperacion;
    }

}
