using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal class MyPet : Animal
    {
        
        public MyPet(int eyes, int ear, int legs, string? name) : base(eyes, ear, legs)
        {
            this.Name = name;
        }

        public string? Name { get; set; } = string.Empty;

        public override void Sound()
        {
            if(Name.ToLower().Equals("dog"))
            {
                Console.WriteLine("Bow Bow");
            }
            else if(Name.ToLower().Equals("cat"))
            {
                Console.WriteLine("meow meow");
            }
            
        }

    }
}
