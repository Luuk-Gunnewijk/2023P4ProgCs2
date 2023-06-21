namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = "C:\\Users\\luukg\\Documents\\Ma\\bewijzenmap\\periode1.4\\unit(prog)\\2023P4ProgCs2";

            DirectoryInfo dir = new DirectoryInfo(path);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dir);
            }
        }
    }
}