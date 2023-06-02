namespace Alphabet;

class Program
{
    static void Main(string[] args)
    {
        char c = 'a';
        Console.WriteLine(c +" = " + "'" +c+ "'");
        for(int i = 97; i<122;i++)
        {
            c++;
            Console.WriteLine(c +" = " + "'" +c+ "'");

        }
    }
}
