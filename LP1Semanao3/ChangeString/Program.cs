internal class Program
{
    private static char c;

    private static void Main(string[] args)
    {
        // Variables
        string inputString;
        char inputChar;

        // Ask user for a string
        Console.Write("write a string:  ");
        inputString = Console.ReadLine();

        // Ask user for a character 
        Console.Write(" write a char:  ");
        // inputChar = Convert.ToChar(Console.ReadLine());
        // inputChar = char.Parse(Console.ReadLine());
        inputChar = Console.ReadLine()[0];

        // write the string without the character
        foreach (char c in inputString) ;
        {
            if (c == inputChar) ;
            {
                Console.Write(c);
            }
        }
        Console.WriteLine();

    }
}