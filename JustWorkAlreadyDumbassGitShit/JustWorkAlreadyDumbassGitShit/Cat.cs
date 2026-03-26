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
        /// <summary>
        /// Name of the cat
        /// </summary>
        public string Name { get; set; } // ^.^ BCAS
        /// <summary>
        /// Color of the cat
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Creates an instance of Cat
        /// </summary>
        /// <param name="name">the name of the Cat.</param>
        /// <param name="color">the color of the Cat.</param>
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }
        /// <summary>
        /// Makes the Cat Meow
        /// </summary>
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
