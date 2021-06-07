using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ParrotTests
    {
        [Fact]
        public void ShoulBeAbleToCreateParrot()
        {
            Parrot parrot = new();
        }

        [Fact]
        public void ShouldRequireFiveSqFeet()
        {
            Parrot parrot = new();
            int requiredArea = parrot.RequiredSpaceSqFeet;
            Assert.Equal(5, requiredArea);
        }

        [Fact]
        public void ShouldFetBeAbleToGetFavoriteFood()
        {
            Parrot parrot = new();
            string[] food = parrot.FavoriteFood;
            
        }

        [Fact]
        public void ShoulBeFriendlyWithParrots()
        {
            Parrot firstParrot = new();
            Parrot secondParrot = new();
            bool isFriendlyWithParrots = firstParrot.IsFriendlyWith(secondParrot);
            Assert.True(isFriendlyWithParrots);

        }

        [Fact]
        public void ShoulBeFriendlyWithBisons()
        {
            Parrot parrot = new();
            Bison bison = new();
            bool isFriendlyWithBisons = parrot.IsFriendlyWith(bison);
            Assert.True(isFriendlyWithBisons);

        }

        [Fact]
        public void ShoulBeFriendlyWithElephants()
        {
            Parrot parrot = new();
            Elephant elephant = new();
            bool isFriendlyWithElephants = parrot.IsFriendlyWith(elephant);
            Assert.True(isFriendlyWithElephants);

        }

        [Fact]
        public void ShoulBeFriendlyWithTurtles()
        {
            Parrot parrot = new();
            Turtle turtle = new();
            bool isFriendlyWithTurtles = parrot.IsFriendlyWith(turtle);
            Assert.True(isFriendlyWithTurtles);

        }

        [Fact]
        public void ShoulNotBeFriendlyWithLions()
        {
            Parrot parrot = new();
            Lion lion = new();
            bool isFriendlyWithLions = parrot.IsFriendlyWith(lion);
            Assert.False(isFriendlyWithLions);

        }

        [Fact]
        public void ShoulNotBeFriendlyWithSnakes()
        {
            Parrot parrot = new();
            Snake snake = new();
            bool isFriendlyWithSnakes = parrot.IsFriendlyWith(snake);
            Assert.False(isFriendlyWithSnakes);

        }
    }
}
