using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ElephantTests
    {
        [Fact]
        public void ShouldBeAbleToCreateElephant()
        {
             Elephant elephant = new();
        }

        [Fact]
        public void ShouldRequire1000dSqFeet()
        {
            Elephant elephant = new();
            Assert.Equal(1000, elephant.RequiredSpaceSqFeet);
        }

        [Fact]
        public void ShouldBeAbleToGetFavoriteFood()
        {
            Elephant elephant = new();
            List<string> food = elephant.FavoriteFood.ToList<string>();
        }

        [Fact]
        public void ShouldBeFriendlyWithElephants()
        {
            Elephant firstElephant = new();
            Elephant secondElephant = new();
            bool isFrindlyWithElephants = firstElephant.IsFriendlyWith(secondElephant);
            Assert.True(isFrindlyWithElephants);
        }

        [Fact]
        public void ShouldBeFriendlyWithBisons()
        {
            Elephant elephant = new();
            Bison bison = new();
            bool isFrindlyWithBisons = elephant.IsFriendlyWith(bison);
            Assert.True(isFrindlyWithBisons);
        }

        [Fact]
        public void ShouldBeFriendlyWithParrots()
        {
            Elephant elephant = new();
            Parrot parrot = new();
            bool isFriendlyWithParrots = elephant.IsFriendlyWith(parrot);
            Assert.True(isFriendlyWithParrots);
        }

        [Fact]
        public void ShouldBeFriendlyWithTurtles()
        {
            Elephant elephant = new();
            Turtle turtle = new();
            bool isFriendlyWithTurtles = elephant.IsFriendlyWith(turtle);
            Assert.True(isFriendlyWithTurtles);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Elephant elephant = new();
            Lion lion = new();
            Penguin penguin = new();
            Snake snake = new();

            bool isFriendlyWithLions = elephant.IsFriendlyWith(lion);
            bool isFriendlyWithPenguins = elephant.IsFriendlyWith(penguin);
            bool isFriendlyWithSnakes = elephant.IsFriendlyWith(snake);

            Assert.False(isFriendlyWithLions);
            Assert.False(isFriendlyWithPenguins);
            Assert.False(isFriendlyWithSnakes);
        }
    }
}
