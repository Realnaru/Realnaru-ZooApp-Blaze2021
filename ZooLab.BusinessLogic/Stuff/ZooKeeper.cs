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
        
        public bool FeedAnimal(Animal animal)
        {
            if (HasAnimalExperience(animal) && animal.IsHungry)
            {
               foreach (var favoriteFood in animal.FavoriteFood)
                {
                    foreach (var availableFood in AvailableFood)
                    {
                        if (favoriteFood == availableFood.GetType().Name)
                        {
                            animal.Feed(availableFood);
                            return true;
                        }
                        
                    }
                    
                }

                
            }
            return false;
        }
        
    }
}
