namespace Calculadoradesueldo.Class
{
    public class Calculadora
    {
        public void Calculadoradesueldo()
        {
            // Declaracion de variables//
            int horas = 0;
            int precio = 0;
            decimal sueldo = 0;
            //decimal impuesto = 0.18m;
         
            
                Console.WriteLine("Digite las horas que trabajo: ");
                horas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el precio de las horas: ");
                precio = Convert.ToInt32(Console.ReadLine());

                sueldo = (horas * precio);
                Console.WriteLine($"El sueldo es: {sueldo}");
                     

        }
    }

}