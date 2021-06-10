using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Enclosure
    {
        public Enclosure(Zoo parentZoo, string name, int sqFeet)
        {
            ParentZoo = parentZoo;
            Name = name;
            SquareFeet = sqFeet;
        }
        public List<Animal> Animals { get; private set; } = new List<Animal>();
        public string Name { get; private set; }
        public Zoo ParentZoo { get; private set; }
        public int SquareFeet { get; private set; }
        public bool IsFriendlyTo(Animal animal)
        {
            foreach (var creature in Animals)
            {
                if (!creature.IsFriendlyWith(animal))
                {
                    return false;
                }
            }
            return true;
        }

        public void AddAnimals (Animal animal)
        {
            if (SquareFeet >= animal.RequiredSpaceSqFeet)
            {
                foreach (var creature in Animals)
                {
                    if (!creature.IsFriendlyWith(animal))
                    {
                        throw new NotFriendlyAnimalException();
                    }
                }
                Animals.Add(animal);

                foreach (var employee in ParentZoo.Employees)
                {
                    if ((employee.GetType().Name == typeof(ZooKeeper).Name))
                    {
                        (employee as ZooKeeper).AddAnimalExperience(animal);
                    }
                }

                animal.Id = ParentZoo.StartingId;
                ParentZoo.StartingId++;
                SquareFeet -= animal.RequiredSpaceSqFeet;
            } else
            {
                throw new NoAvailableSpaceException();
            }
            
        }
        
    }
}
