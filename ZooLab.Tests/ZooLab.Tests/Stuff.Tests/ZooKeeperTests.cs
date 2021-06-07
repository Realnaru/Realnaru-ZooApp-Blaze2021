﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ZooKeeperTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZooKeeper()
        {
            ZooKeeper zooKeeper = new ZooKeeper("First Name", "Last Name");

        }

        [Fact]
        public void ShouldBeAbleToGetZooKeeperNames()
        {
            ZooKeeper zooKeeper = new ZooKeeper("First Name", "Last Name");

            string firstName = zooKeeper.FirstName;
            string lastName = zooKeeper.LastName;

            Assert.Equal("First Name", firstName);
            Assert.Equal("Last Name", lastName);
        }

        [Fact]
        public void ShouldBeAbleToHaveAnimalExpirience()
        {
            ZooKeeper zookeeper = new("First Name", "Last Name");

            List<string> familiarAnimals = zookeeper.AnimalExperience;

            Assert.Equal(familiarAnimals, zookeeper.AnimalExperience);
        }

        [Fact]
        public void ShouldBeAbleToHaveGetAndSetAvailableFood()
        {
            ZooKeeper zookeeper = new("First Name", "Last Name");
            zookeeper.AvailableFood.Add(new Grass());

            List<Food> availableFood = zookeeper.AvailableFood;

            Assert.Equal(availableFood, zookeeper.AvailableFood);
        }

        [Fact]
        public void ShouldBeAbleToAddNewAnimalToAnimalExperience()
        {
            ZooKeeper zooKeeper = new("First Name", "Last Name");
            zooKeeper.AddAnimalExperience(new Lion());
            string faimiliarAnimal = zooKeeper.AnimalExperience[0];

            Assert.Equal("Lion", faimiliarAnimal);
        }

        [Fact]
        public void ShouldBeAbleToCheckIfHasAnimalExpirience()
        {
            ZooKeeper zooKeeper = new("First Name", "Last Name");
            zooKeeper.AddAnimalExperience(new Elephant());

            Assert.True(zooKeeper.HasAnimalExperience(new Elephant()));
            Assert.False(zooKeeper.HasAnimalExperience(new Lion()));
        }

        [Fact]
        public void ShouldBeAbleToFeedlHungryAnimalIfHasExperienceWith()
        {
            ZooKeeper zooKeeper= new("First Name", "Last Name");
            zooKeeper.AvailableFood.Add(new Grass());
            Animal bison = new Bison();
            bison.IsHungry = true;
            zooKeeper.AddAnimalExperience(bison);
            bool canZooKeeperFeedBison = zooKeeper.FeedAnimal(bison);
            Assert.True(canZooKeeperFeedBison);
            Assert.False(bison.IsHungry);
        }

        [Fact]
        public void ShouldNotBeAbleToFeedSickAnimalIfHasNoExperience()
        {
            ZooKeeper zooKeeper = new ("First Name", "Last Name");
            Animal lion = new Lion();
            lion.IsSick = true;
            zooKeeper.AddAnimalExperience(new Bison());
            bool canZooKeeperHealBison = zooKeeper.FeedAnimal(lion);
            Assert.False(canZooKeeperHealBison);
            Assert.True(lion.IsSick);
        }

        [Fact]
        public void ShouldNotBeAbleToFeedSickAnimalIfHasNoFavoriteFood()
        {
            ZooKeeper zooKeeper = new("First Name", "Last Name");
            zooKeeper.AvailableFood.Add(new Vegetable());
            Animal lion = new Lion();
            lion.IsSick = true;
            zooKeeper.AddAnimalExperience(new Lion());
            bool canZooKeeperFeedLion = zooKeeper.FeedAnimal(lion);
            Assert.True(lion.IsSick);
            Assert.False(canZooKeeperFeedLion);
            
        }

        [Fact]
        public void ShouldNotHealHealthyAnimal()
        {
            ZooKeeper zooKeeper = new ("First Name", "Last Name");
            Animal lion = new Lion();
            lion.IsSick = false;
            zooKeeper.AddAnimalExperience(new Lion());
            bool canZooKeeperHealBison = zooKeeper.FeedAnimal(lion);
            Assert.False(canZooKeeperHealBison);
            Assert.False(lion.IsSick);
        }
    }
}
