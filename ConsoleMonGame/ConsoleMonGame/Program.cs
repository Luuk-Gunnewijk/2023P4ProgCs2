namespace ConsoleMonGame
{
    internal class Program
    {
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestConsoleMonFunctions();
        }
    }

    class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }

    class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
    }
}