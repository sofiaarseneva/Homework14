using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Dog : Animal
    {
        string name;
        string voice;

        public Dog(string name, string voice) : base(name)
        {
            this.voice = voice;
        }
        public override string Name { get => name; set => name = value; }

        public override void Say()
        {
            Console.WriteLine(voice);
        }
    }
}
