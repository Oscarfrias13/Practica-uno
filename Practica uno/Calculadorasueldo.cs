public class Calculadorasueldo
{
    public void Calculadoradesueldo()
    {
        // Declaracion de variables//
        int horas = 0;
        int precio = 0;
        decimal sueldo = 0;
        decimal impuesto = 0.18m;
        decimal sueldoneto = 0;

        try
        {
            Console.WriteLine("Digite las horas que trabajo: ");
            horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el precio de las horas: ");
            precio = int.Parse(Console.ReadLine());

            sueldo = (horas * precio);
            Console.WriteLine($"El sueldo antes de impuesto es: {sueldo}");

            sueldoneto = (sueldo * impuesto);
            Console.WriteLine($"Total de impuesto a pagar: {sueldoneto}");

            sueldo = (sueldo - sueldoneto);
            Console.WriteLine($"El valor neto de su pago sera: {sueldo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"El siguiente error se ha producido: {ex.Message}");
        }

    }
}