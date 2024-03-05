namespace Labsemana7
{
    class DespejedeF
    {
        static void Main(string [] args)
        {
            int vf = 0;
            int a = 0;
            int t = 0;
            

            Console.WriteLine("Ingrese la aceleración: ");
                a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo: ");
                t = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad final: ");
                vf = Int32.Parse(Console.ReadLine());

            int vi = vf - (a*t);

            Console.Write("La velocidad inicial = " + vi);

            Console.ReadKey();

        }
    }
}