using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Parrot : Bird
    {
        public override int RequiredSpaceSqFeet { get;} = 5;

        public override string[] FavoriteFood { get; } = {"Grass", "Vegetable"};

        public override bool IsFriendlyWith(Animal animal)
        {
            var parrot = typeof(Parrot).ToString();
            var bison = typeof(Bison).ToString();
            var elephant= typeof(Elephant).ToString();
            var turtle = typeof(Turtle).ToString();
            String[] animals = new String[] { parrot, bison, elephant, turtle};
            foreach (var creature in animals)
            {
                if (creature == animal.GetType().ToString())
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
