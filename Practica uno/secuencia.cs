using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_uno
{
    public class secuencia
    {
     public void secuancias()
        {
            //variables //
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;


            Console.WriteLine("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine($"La suma de ambos numero es: {suma}");
            Console.WriteLine($"La multiplicacion de ambos numeros es: {producto}");

        }

    }
}

