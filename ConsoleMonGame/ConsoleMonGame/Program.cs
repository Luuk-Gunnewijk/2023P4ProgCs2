﻿namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
    }

    class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
    }
}