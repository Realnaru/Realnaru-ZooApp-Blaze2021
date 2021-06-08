﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Enclosure
    {
        public Enclosure()
        {

        }
        public Enclosure(string name, int sqFeet)
        {
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
                SquareFeet -= animal.RequiredSpaceSqFeet;
            } else
            {
                throw new NoAvailableSpaceException();
            }
            
        }
        
    }
}
