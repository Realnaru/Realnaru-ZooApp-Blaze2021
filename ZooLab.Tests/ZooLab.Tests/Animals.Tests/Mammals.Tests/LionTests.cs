using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class LionTests
    {
        [Fact]
        public void ShouldBeAbleToCreateLion()
        {
            Lion lion = new();
        }

        [Fact]
        public void ShouldRequire1000SqFeet()
        {
            Lion lion = new();
            int requiredArea = lion.RequiredSpaceSqFeet;
            Assert.Equal(1000, requiredArea);
        }

        [Fact]
        public void ShouldBeAbletToGetFavoriteFood()
        {
            Lion lion = new();
            List<string> food = lion.FavoriteFood.ToList<string>();
        }

        [Fact]
        public void ShouldBeFriendlyWithLions()
        {
            Lion firstLion = new();
            Lion secondLion = new();
            bool isFriendlyWithLions = firstLion.IsFriendlyWith(secondLion);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Lion lion = new();
            Elephant elephant = new();
            Bison bison = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();
            Snake snake = new();

            bool isFriendlyWithElephants = lion.IsFriendlyWith(elephant);
            bool isFriendlyWithBisons = lion.IsFriendlyWith(bison);
            bool isFriendlyWithPenguins = lion.IsFriendlyWith(penguin);
            bool isFriendlyWithParrots = lion.IsFriendlyWith(parrot);
            bool isFriendlyWithTurtles = lion.IsFriendlyWith(turtle);
            bool isFriendlyWithSnakes = lion.IsFriendlyWith(snake);

            Assert.False(isFriendlyWithElephants);
            Assert.False(isFriendlyWithBisons);
            Assert.False(isFriendlyWithPenguins);
            Assert.False(isFriendlyWithParrots);
            Assert.False(isFriendlyWithTurtles);
            Assert.False(isFriendlyWithSnakes);
        }
    }
}
