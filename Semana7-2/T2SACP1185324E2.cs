using System.Timers;

namespace Semana7
{
    class T2SACP1185324E2
    { 
        static void Main(string [] args)
        {
            double valor = 0;  

            Console.WriteLine("Jorge López - 1422616 \n Ingrese un número menor a 1000: ");
                valor = Double.Parse(Console.ReadLine());
        if (valor >= 1000)
        {
            Console.WriteLine("El valor no es válido");
        } 
        else
        {
            int valorIngresado = (int) (valor * 100);
            int B100 = valorIngresado / 10000;
            valorIngresado %= 10000;
            int B50 = valorIngresado / 5000;
            valorIngresado %= 5000;
            int B20 = valorIngresado / 2000;
            valorIngresado %= 2000;
            int B10 = valorIngresado / 1000;
            valorIngresado %= 1000;
            int B5 =valorIngresado / 500;
            valorIngresado %= 500;
            int M1 = valorIngresado / 100;
            valorIngresado %= 100;
            int C25 = valorIngresado / 25;
            valorIngresado %= 25;
            int C1 = valorIngresado / 1;
            valorIngresado %= 1;
           
            Console.WriteLine(B100 + " de billetes de 100");
            Console.WriteLine(B50 + " de billetes de 50");
            Console.WriteLine(B20 + " de billetes de 20");
            Console.WriteLine(B10 + " de billetes de 10");
            Console.WriteLine(B5 + " de billetes de 5");
            Console.WriteLine(M1 + " de monedas de 1");
            Console.WriteLine(C25 + " de centavos de 25");
            Console.WriteLine(C1 + " de centavos de 1");
             
        }
        Console.ReadKey();
            
        }
    }
}