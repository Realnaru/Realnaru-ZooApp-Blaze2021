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

        public void AddAnimals (Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
