using System;
using LegoMiniFigures.MiniFigures;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralGrievous droid = new GeneralGrievous("Round", "Kaleesh", "Droid legs", "Many lightsabers");
            ObiWanKenobi jedi = new ObiWanKenobi("Round", "Jedi Robe", "Brown pants", "One lightsaber and his brain");
            Console.WriteLine("------------------------------------------");
            jedi.Greeting();
            droid.Greeting();
            droid.Attack();
            jedi.Attack();
            jedi.Jump();
            droid.Run();
            jedi.Kills();
            droid.Dies();
        }
    }
}
