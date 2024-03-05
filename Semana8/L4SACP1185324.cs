using System.ComponentModel.Design.Serialization;

namespace Semana8
{
   class  L4SACP1185324
   {
        static void Main(string[]args)
        {
            int n;
            int resultado;
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 2;

            Console.WriteLine("Ingrese un neumero que sea mayor a cero: ");
                n = Int32.Parse(Console.ReadLine());
            
            while(n > 0)
            {   
                resultado = a;
                
                Console.WriteLine("La sucesión Fibonacci sería:\n" + resultado);

                if (n > 1)
                {
                    resultado += b;
                }
                if (n > i)
                {
                    c = a + b;
                    resultado += c;
                    a = c;
                }
                Console.WriteLine(resultado);
                i += 1;
                
                break;
                }
            
            
            Console.ReadKey();
            }
           
        }
    }

