using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.MiniFigures
{
    class GeneralGrievous
    {
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public GeneralGrievous(string head, string torso, string legs, string accessories)
        {
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
            Console.WriteLine($"General Grievous' head is {head}. Torso and legs are {torso} & {legs}. He always has {accessories} with him.");
        }
        public void Run()
        {
            Console.WriteLine("Grievous runs like a coward");
        }
        public void Attack()
        {
            Console.WriteLine("Grievous swings his many lightsabers");
        }
        public void Greeting()
        {
            Console.WriteLine("General Kenobi!");
        }
        public void Dies()
        {
            Console.WriteLine("*gets shot* AHHHhHhHhH *falls over*");
        }
    }
}
