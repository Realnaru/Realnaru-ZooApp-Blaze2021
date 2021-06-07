using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Penguin : Bird
    {
        public override int RequiredSpaceSqFeet { get; } = 10;

        public override string[] FavoriteFood { get; } = { "Vegetable", "Meat" };

        public override bool IsFriendlyWith(Animal animal)
        {
            var penguin = typeof(Penguin).ToString();
            var creature = animal.GetType().ToString();
            if (penguin == creature)
            {
                return true;
            }
            return false;
        }
    }
}
