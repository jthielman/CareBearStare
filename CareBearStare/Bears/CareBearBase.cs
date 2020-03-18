using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    abstract class CareBearBase
    {
        public string Name { get; protected set; }
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }

        public abstract void Stare(); // "abstract" means it has to be defined (using "override") when instantiated

        public void Care(string humanToCareFor) // can't be changed
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug) // "virtual" means it can be changed or left as is
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }

    }
}
