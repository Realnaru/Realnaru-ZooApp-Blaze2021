using System;
using ZooLab.BusinessLogic;

namespace ZooLab
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Zoo zoo = new(new MockConsole());

            zoo.AddEnclosure("Lions enclosure", 10000);
            zoo.AddEnclosure("Elephants enclosure", 10000);

            Lion lion = new();
            Elephant elephant = new();

            Veterinarian veterinarian = new("John", "Doe");

            veterinarian.AvailableMedicine.Add(new Antibiotic());
            veterinarian.AvailableMedicine.Add(new AntiDepression());
            veterinarian.AvailableMedicine.Add(new AntiInflammatory());
            veterinarian.AddAnimalExperience(lion);
            veterinarian.AddAnimalExperience(elephant);

            zoo.HireEmployee(veterinarian);

            lion.IsSick = false;
            elephant.IsSick = false;

            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);

            zoo.HealAnimals();*/

             Zoo zoo = new(new MockConsole());

             zoo.AddEnclosure("Lions enclosure", 10000);
             zoo.AddEnclosure("Elephants enclosure", 10000);

             Lion lion = new();
             Elephant elephant = new();

             ZooKeeper zooKeeper = new("John", "Doe");
             zooKeeper.AvailableFood.Add(new Grass());
             zooKeeper.AvailableFood.Add(new Vegetable());
             zooKeeper.AvailableFood.Add(new Meat());
             zooKeeper.AddAnimalExperience(lion);
             zooKeeper.AddAnimalExperience(elephant);

             zoo.HireEmployee(zooKeeper);

             lion.IsHungry = true;
             elephant.IsHungry = true;

             zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
             zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);

             zoo.FeedAnimals();

        }
    }
}
