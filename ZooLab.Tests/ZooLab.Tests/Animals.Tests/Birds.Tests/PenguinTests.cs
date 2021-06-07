using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class PenguinTests
    {
        [Fact]
        public void ShoulBeAbleToCreatePenguin()
        {
            Penguin penguin = new();
        }

        [Fact]
        public void ShouldRequireTenSqFeet()
        {
            Penguin penguin = new();
            int requiredArea = penguin.RequiredSpaceSqFeet;
            Assert.Equal(10, requiredArea);
        }

        [Fact]
        public void ShouldBeAbleToGetFavoriteFood()
        {
            Penguin penguin = new();
            List<string> food = penguin.FavoriteFood.ToList<string>();


        }

        [Fact]
        public void ShouldBeFriendlyWithPinguins()
        {
            Penguin firstPenguin = new();
            Penguin secondPenguin = new();

            bool isFriendlyWithPenguins = firstPenguin.IsFriendlyWith(secondPenguin);
            Assert.True(isFriendlyWithPenguins);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Penguin penguin = new();
            Parrot parrot = new();
            Bison bison = new();
            Elephant elephant = new();
            Lion lion = new();
            Snake snake = new();
            Turtle turtle = new();

            bool isFriendlyWithParrots = penguin.IsFriendlyWith(parrot);
            bool isFriendlyWithBisons = penguin.IsFriendlyWith(bison);
            bool isFriendlyWithElephants = penguin.IsFriendlyWith(elephant);
            bool isFriendlyWithLions = penguin.IsFriendlyWith(lion);
            bool isFriendlyWithSnakes = penguin.IsFriendlyWith(snake);
            bool isFriendlyWithTurtles = penguin.IsFriendlyWith(turtle);

            Assert.False(isFriendlyWithParrots);
            Assert.False(isFriendlyWithBisons);
            Assert.False(isFriendlyWithElephants);
            Assert.False(isFriendlyWithLions);
            Assert.False(isFriendlyWithSnakes);
            Assert.False(isFriendlyWithTurtles);

        }




    }
}
