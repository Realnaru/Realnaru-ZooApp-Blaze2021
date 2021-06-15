using System;
using System.Collections.Generic;
using ZooLab.BusinessLogic;


namespace ZooLab
{
    public class Program
    {
        static void Main(string[] args)

        {
            RunZoo(new MockConsole());
        }

        public static List<string> RunZoo(MockConsole mockConsole)
        {

            Zoo firstZoo = new(mockConsole);
            firstZoo.AddLocation("LA");

            firstZoo.AddEnclosure("Lions enclosure", 1000);
            firstZoo.AddEnclosure("Elephants enclosure", 1000);
            firstZoo.AddEnclosure("Bisons enclosure", 1000);
            firstZoo.AddEnclosure("Penguins enclosure", 15);
            firstZoo.AddEnclosure("Parrots enclosure", 5);
            firstZoo.AddEnclosure("Turtles enclosure", 5);
            firstZoo.AddEnclosure("Snakes enclosure", 5);

            Lion firstLion = new();
            Elephant firstElephant = new();
            Bison firstBison = new();
            Penguin firstPenguin = new();
            Parrot firstParrot = new();
            Turtle firstTurtle = new();
            Snake firstSnake = new();

            firstLion.IsSick = true;
            firstElephant.IsSick = true;
            firstBison.IsSick = true;
            firstPenguin.IsSick = true;
            firstParrot.IsSick = true;
            firstTurtle.IsSick = true;
            firstSnake.IsSick = true;


            Veterinarian veterinarian = new("John", "Doe");

            veterinarian.AvailableMedicine.Add(new Antibiotic());
            veterinarian.AvailableMedicine.Add(new AntiDepression());
            veterinarian.AvailableMedicine.Add(new AntiInflammatory());

            veterinarian.AddAnimalExperience(firstLion);
            veterinarian.AddAnimalExperience(firstElephant);
            veterinarian.AddAnimalExperience(firstBison);
            veterinarian.AddAnimalExperience(firstPenguin);
            veterinarian.AddAnimalExperience(firstParrot);
            veterinarian.AddAnimalExperience(firstTurtle);
            veterinarian.AddAnimalExperience(firstSnake);

            firstZoo.HireEmployee(veterinarian);

            firstZoo.FindAvailableEnclosure(firstLion).AddAnimals(firstLion);
            firstZoo.FindAvailableEnclosure(firstElephant).AddAnimals(firstElephant);
            firstZoo.FindAvailableEnclosure(firstBison).AddAnimals(firstBison);
            firstZoo.FindAvailableEnclosure(firstPenguin).AddAnimals(firstPenguin);
            firstZoo.FindAvailableEnclosure(firstParrot).AddAnimals(firstParrot);
            firstZoo.FindAvailableEnclosure(firstTurtle).AddAnimals(firstTurtle);
            firstZoo.FindAvailableEnclosure(firstSnake).AddAnimals(firstSnake);

            firstZoo.HealAnimals();

            Zoo secondZoo = new(mockConsole);
            secondZoo.AddLocation("SF");

            secondZoo.AddEnclosure("Lions enclosure", 1000);
            secondZoo.AddEnclosure("Elephants enclosure", 1000);
            secondZoo.AddEnclosure("Bisons enclosure", 1000);
            secondZoo.AddEnclosure("Penguins enclosure", 15);
            secondZoo.AddEnclosure("Parrots enclosure", 5);
            secondZoo.AddEnclosure("Turtles enclosure", 5);
            secondZoo.AddEnclosure("Snakes enclosure", 5);


            Lion secondLion = new();
            Elephant secondElephant = new();
            Bison secondBison = new();
            Penguin secondPenguin = new();
            Parrot secondParrot = new();
            Turtle secondTurtle = new();
            Snake secondSnake = new();

            ZooKeeper zooKeeper = new("Jein", "Doe");
            zooKeeper.AvailableFood.Add(new Grass());
            zooKeeper.AvailableFood.Add(new Vegetable());
            zooKeeper.AvailableFood.Add(new Meat());

            zooKeeper.AddAnimalExperience(secondLion);
            zooKeeper.AddAnimalExperience(secondElephant);
            zooKeeper.AddAnimalExperience(secondBison);
            zooKeeper.AddAnimalExperience(secondPenguin);
            zooKeeper.AddAnimalExperience(secondParrot);
            zooKeeper.AddAnimalExperience(secondTurtle);
            zooKeeper.AddAnimalExperience(secondSnake);


            secondZoo.HireEmployee(zooKeeper);

            secondLion.IsHungry = true;
            secondElephant.IsHungry = true;
            secondBison.IsHungry = true;
            secondPenguin.IsHungry = true;
            secondParrot.IsHungry = true;
            secondTurtle.IsHungry = true;
            secondSnake.IsHungry = true;

            secondZoo.FindAvailableEnclosure(secondLion).AddAnimals(secondLion);
            secondZoo.FindAvailableEnclosure(secondElephant).AddAnimals(secondElephant);
            secondZoo.FindAvailableEnclosure(secondBison).AddAnimals(secondBison);
            secondZoo.FindAvailableEnclosure(secondPenguin).AddAnimals(secondPenguin);
            secondZoo.FindAvailableEnclosure(secondParrot).AddAnimals(secondParrot);
            secondZoo.FindAvailableEnclosure(secondTurtle).AddAnimals(secondTurtle);
            secondZoo.FindAvailableEnclosure(secondSnake).AddAnimals(secondSnake);

            secondZoo.FeedAnimals();

            return mockConsole.Log;
        }


    }
    
}
