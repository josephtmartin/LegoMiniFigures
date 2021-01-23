using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.MiniFigures
{
    class ObiWanKenobi
    {
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public ObiWanKenobi(string head, string torso, string legs, string accessories)
        {
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
            Console.WriteLine($"Obi-Wan Kenobi's head is {head}. Torso and legs are {torso} & {legs}. He always carries {accessories} with him.");
        }
        public void Jump() => Console.WriteLine("Obi-Wan Kenobi jumps");
        public void Attack() => Console.WriteLine("Obi-Wan Kenobi swings his lightsaber");
        public void Greeting() => Console.WriteLine("Hello there!");
        public void Kills() => Console.WriteLine("*hangs on edge* *grabs blaster* *shoots grievous*");
    }
}
