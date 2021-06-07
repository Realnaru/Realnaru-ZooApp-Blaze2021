using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Snake : Reptile
    {
        public override int RequiredSpaceSqFeet { get; } = 2;

        public override string[] FavoriteFood { get; } = { "Meat"};

        public override bool IsFriendlyWith(Animal animal)
        {
            return (typeof(Snake) == animal.GetType());
        }
    }
}
