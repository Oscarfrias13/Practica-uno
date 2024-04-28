using System;

public class Class1
{
    public Class1()
    {
        //variables 
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int producto = 0;

        try
        {
            Console.WriteLine("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine($"La suma de ambos numero es: {suma}");
            Console.WriteLine($"La multiplicacion de ambos numeros es: {producto}");

        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
