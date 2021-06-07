using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class BisonTests
    {
        [Fact]
        public void ShoulBeAbleToCreateBison()
        {
            Bison bison = new();
        }

        [Fact]
        public void ShoulRequire1000SqFeet()
        {
            Bison bison = new();
            int requiredArea = bison.RequiredSpaceSqFeet;
            Assert.Equal(1000, requiredArea);
        }

        [Fact]
        public void ShouldBeAbleToGetFavoriteFood()
        {
            Bison bison = new();
            List<string> food = bison.FavoriteFood.ToList<string>();
        }

        [Fact]
        public void ShouldBeFriendlyWithBisons()
        {
            Bison firstBison = new();
            Bison secondBison = new();

            bool isFrindlyWithBisons = firstBison.IsFriendlyWith(secondBison);
            Assert.True(isFrindlyWithBisons);
        }

        [Fact]
        public void ShouldBeFriendlyWithElephants()
        {
            Bison bison = new();
            Elephant elephant = new();

            bool isFrindlyWithElephants = bison.IsFriendlyWith(elephant);
            Assert.True(isFrindlyWithElephants);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Bison bison = new();
            Lion lion = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();
            Snake snake = new();

            bool isFrindlyWithLions = bison.IsFriendlyWith(lion);
            bool isFrindlyWithPenguins = bison.IsFriendlyWith(penguin);
            bool isFrindlyWithParrots = bison.IsFriendlyWith(parrot);
            bool isFrindlyWithTurtles = bison.IsFriendlyWith(turtle);
            bool isFrindlyWithSnakes = bison.IsFriendlyWith(snake);

            Assert.False(isFrindlyWithLions);
            Assert.False(isFrindlyWithPenguins);
            Assert.False(isFrindlyWithParrots);
            Assert.False(isFrindlyWithTurtles);
            Assert.False(isFrindlyWithSnakes);
        }
    }


}
