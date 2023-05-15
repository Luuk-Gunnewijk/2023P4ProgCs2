namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> birds = new List<string>();
            List<string> birds2 = new List<string>();

            birds.Add("uil");
            birds.Add("kraai");
            birds.Add("hond");
            birds.Add("papegaai");

            birds2.Add("meeuw");
            birds2.Add("duif");

            birds.AddRange(birds2);

            birds.Remove(birds[2]);

            foreach (string item in birds)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}