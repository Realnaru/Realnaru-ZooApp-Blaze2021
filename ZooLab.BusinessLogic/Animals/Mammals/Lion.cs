using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Lion : Mammal
    {
        public override int RequiredSpaceSqFeet { get; } = 1000;

        public override string[] FavoriteFood { get; } = { "Meat", "Grass"};

        public override bool IsFriendlyWith(Animal animal)
        {
            return (typeof(Lion) == animal.GetType());
        }
    }
}
