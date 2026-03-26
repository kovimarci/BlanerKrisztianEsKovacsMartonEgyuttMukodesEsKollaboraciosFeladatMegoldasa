using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustWorkAlreadyDumbassGitShit
{
    /// <summary>
    /// Cat as in Feline
    /// </summary>
    internal class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"Cat {Name} {Color}";
        }
    }
}
