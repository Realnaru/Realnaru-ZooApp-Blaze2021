using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class ZooKeeper : IEmployee
    {
        public ZooKeeper(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public List<string> AnimalExperience { get; } = new List<string>();

        public List<Food> AvailableFood { get; set; } = new List<Food>();

        public void AddAnimalExperience(Animal animal)
        {
            if (!AnimalExperience.Contains(animal.GetType().ToString()))
            {
                AnimalExperience.Add(animal.GetType().Name);
            }
        }
        public bool HasAnimalExperience(Animal animal)
        {
            foreach (var creature in AnimalExperience)
            {
                if (creature == animal.GetType().Name)
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool FeedAnimal(Animal animal, IConsole zooConsole = null)
        {
            if (HasAnimalExperience(animal) && (animal.IsHungry) || (animal.FeedSchedule.Count > 0 && animal.FeedSchedule[0] > Convert.ToInt32(DateTime.Now.Hour) || animal.FeedSchedule[1] > Convert.ToInt32(DateTime.Now.Hour)))
            {
               foreach (var favoriteFood in animal.FavoriteFood)
                {
                    foreach (var availableFood in AvailableFood)
                    {
                        if (favoriteFood == availableFood.GetType().Name)
                        {
                            animal.Feed(availableFood);
                            FeedTime feedTime = new();
                            feedTime.TimeToFeed = DateTime.Now;
                            feedTime.FedByZookeeper = this;
                            animal.FeedTimes.Add(feedTime);
                            return true;
                        }
                        
                    }
                    
                }

                
            }
            return false;
        }
        
    }
}
