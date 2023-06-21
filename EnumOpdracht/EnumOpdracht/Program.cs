namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            colors myMainThemeColor = colors.blue;

            if(myMainThemeColor == colors.blue)
            {
                Console.WriteLine("Dat is mijn kleur");
            }
        }
    }
}