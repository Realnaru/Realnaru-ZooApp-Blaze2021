using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Veterinarian : IEmployee
    {
        public Veterinarian(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public List<Medicine> AvailableMedicine { get; set; } = new List<Medicine>();

        public List<string> AnimalExperience { get; } = new List<string>();

        public void AddAnimalExperience(Animal animal)
        {
            if (!AnimalExperience.Contains(animal.GetType().ToString())) {
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

        public bool HealAnimal(Animal animal)
        {
            if (HasAnimalExperience(animal) && animal.IsSick)
            {
                foreach (var medicine in AvailableMedicine)
                {
                    if (medicine.GetType().Name == animal.NeededMedicine)
                    {
                        animal.Heal(medicine);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
