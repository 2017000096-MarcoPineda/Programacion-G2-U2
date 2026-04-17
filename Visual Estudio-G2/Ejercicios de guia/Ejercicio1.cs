internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS");
        Console.WriteLine("*********************************************");
        Console.WriteLine("1- Seno");
        Console.WriteLine("2- Coseno");
        Console.WriteLine("3- Tangente");
        Console.WriteLine("*********************************************");

        Console.Write("Seleccione una opción (1-3): ");
        int op = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el ángulo en grados: ");
        double ang = Convert.ToDouble(Console.ReadLine());
        double rads = ang * (Math.PI / 180);

        switch (op)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(rads));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(rads));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(rads));
                break;
            default:
                Console.WriteLine("ERROR");
                break;
            }   
        }
}