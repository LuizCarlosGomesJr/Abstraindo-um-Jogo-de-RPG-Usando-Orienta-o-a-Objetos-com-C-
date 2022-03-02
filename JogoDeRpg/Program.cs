using System;
using JogoDeRpg.src.Entities;

namespace JogoDeRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Hero wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack());
        }
    }
}
