using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal abstract class Animal
    {
        private int eyes, ear, legs;
        protected Animal(int eyes, int ear, int legs)
        {
            this.Eyes = eyes;
            this.Ear = ear;
            this.Legs = legs;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ear { get => ear; set => ear = value; }
        public int Legs { get => legs; set => legs = value; }


        public static void Sleep()
        {
            Console.WriteLine("zzzzzzz");
        }
        public static void Eat()
        {
            Console.WriteLine("mmmmmmmm");
        }
        public void AboutMe()
        {
            Console.WriteLine($"I have {Eyes} eyes");
        }

        public abstract void Sound();

    }
}
