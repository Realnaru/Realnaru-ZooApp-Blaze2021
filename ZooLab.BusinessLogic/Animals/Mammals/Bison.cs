using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Bison : Mammal
    { 
        public override int RequiredSpaceSqFeet { get; } = 1000;

        public override string[] FavoriteFood { get; } = { "Grass", "Vegetable" };

        public override bool IsFriendlyWith(Animal animal)
        {
            return (typeof(Bison) == animal.GetType() ||
                typeof(Elephant) == animal.GetType());
        }
    }
}
