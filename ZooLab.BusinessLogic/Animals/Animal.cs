using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public abstract class Animal
    {
        public abstract int RequiredSpaceSqFeet { get; }
        public abstract string[] FavoriteFood { get; }

        public List<FeedTime> FeedTimes { get; set; }

        public List<int> FeedSchedule { get; private set; }

        public bool IsSick { get; set; } = (new Random().Next(0, 10) > 5) ? true : false;

        public bool IsHungry { get; set; } = (new Random().Next(0, 10) > 5) ? true : false;

        public int Id { get; set; }

        public abstract bool IsFriendlyWith(Animal animal);

        public void AddFeedSchedule(List<int> hours)
        {
            FeedSchedule = hours;
        }

        public void Feed(Food food)
        {
            foreach (var anyFood in FavoriteFood)
            {
                if (food.GetType().Name == anyFood)
                {
                    IsHungry = false;
                }
            }
        }
        public void Heal (Medicine medicine)
        {

        }
        
    }
}
