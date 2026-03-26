using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustWorkAlreadyDumbassGitShit
{
    /// <summary>
    /// Dogs can go to hell...
    /// </summary>
    public class Dog(string _name, string _breed)
    {
        public string Name { get; set; } = _name;
        public string Breed { get; set; } = _breed;

        public void Bark()
        {
            Console.WriteLine($"{Name} vau!");
        }
        public void Fetch()
        {
            Console.WriteLine("Fetched some balls!");
        }
    }
}
