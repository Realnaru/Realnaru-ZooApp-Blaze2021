using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Turtle : Reptile
    {
        public override int RequiredSpaceSqFeet { get; } = 2;

        public override string[] FavoriteFood { get; } = { "Grass", "Vegetable" };

        public override bool IsFriendlyWith(Animal animal)
        {
            return (typeof(Turtle) == animal.GetType() ||
                typeof(Parrot) == animal.GetType() ||
                typeof(Bison) == animal.GetType() ||
                typeof(Elephant) == animal.GetType());
        }
    }
}
