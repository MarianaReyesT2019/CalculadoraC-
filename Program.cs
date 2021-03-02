using System;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidad1;
            double cantidad2;
            string operacion;
            double resultado;


            Console.WriteLine("Escribe la operacion que desea realizar");
            Console.WriteLine("suma");
            Console.WriteLine("resta");
            Console.WriteLine("multiplicacion");
            Console.WriteLine("division");

            operacion = Console.ReadLine();

            Console.WriteLine("Escribe la primera cantidad");
            cantidad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la segunda cantidad");
            cantidad2 = Convert.ToDouble(Console.ReadLine());


            Console.Clear();


            if(operacion == "suma")
            {
                resultado = cantidad1 + cantidad2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
                Console.ReadLine();

            }

            if(operacion  == "resta")
            {
                resultado = cantidad1 - cantidad2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
                Console.ReadLine();

            }

            if( operacion == "multiplicacion")
            {
                resultado = cantidad1 * cantidad2;
                Console.WriteLine("El resultado de la multiplicaion es: " + resultado);
                Console.ReadLine();

            }

            if (operacion == "division ")
            {
                resultado = cantidad1 / cantidad2;
                Console.WriteLine(" El resultado de la division es: " + resultado);
                Console.ReadLine();

            }
            
        }
    }
}
