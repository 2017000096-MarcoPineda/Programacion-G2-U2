internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un carácter: ");
        char c = Convert.ToChar(Console.ReadLine().ToLower());

        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("es una vocal");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("es un digito");
                break;
            default:
                Console.WriteLine("no es ni vocal ni digito");
                break;
        }
    }
}