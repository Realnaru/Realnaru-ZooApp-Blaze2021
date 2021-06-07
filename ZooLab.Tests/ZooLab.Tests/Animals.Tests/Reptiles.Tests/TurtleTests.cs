using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class TurtleTests
    {
        [Fact]
        public void ShoulBeAbleToCreateTurtle()
        {
            Turtle turtle = new();
        }

        [Fact]
        public void ShoulRequire2SqFeet()
        {
            Turtle turtle = new();
            int requiredArea = turtle.RequiredSpaceSqFeet;
            Assert.Equal(2, requiredArea);
        }

        [Fact]
        public void ShoulBeAbleToGetFavoriteFood()
        {
            Turtle turtle = new();
            List<string> food = turtle.FavoriteFood.ToList<string>();
        }

        [Fact]
        public void ShoulBeFriendlyWithTurtles()
        {
            Turtle firstTurtle = new();
            Turtle secondTurtle = new();

            bool isFriendlyWithTurtles = firstTurtle.IsFriendlyWith(secondTurtle);
            Assert.True(isFriendlyWithTurtles);
        }

        [Fact]
        public void ShoulBeFriendlyWithParrots()
        {
            Turtle turtle = new();
            Parrot parrot = new();

            bool isFriendlyWithParrots = turtle.IsFriendlyWith(parrot);
            Assert.True(isFriendlyWithParrots);
        }

        [Fact]
        public void ShoulBeFriendlyWithBisons()
        {
            Turtle turtle = new();
            Bison bison = new();

            bool isFriendlyWithBisons = turtle.IsFriendlyWith(bison);
            Assert.True(isFriendlyWithBisons);
        }

        [Fact]
        public void ShoulBeFriendlyWithElephants()
        {
            Turtle turtle = new();
            Elephant elephant = new();

            bool isFriendlyWithElephants = turtle.IsFriendlyWith(elephant);
            Assert.True(isFriendlyWithElephants);
        }

        [Fact]
        public void ShoulNotBeFriendlyWithOtherAnimals()
        {
            Turtle turtle = new();
            Lion lion = new();
            Penguin penguin = new();
            Snake snake = new();

            bool isFriendlyWithLions = turtle.IsFriendlyWith(lion);
            bool isFriendlyWithPenguins = turtle.IsFriendlyWith(penguin);
            bool isFriendlyWithSnakes = turtle.IsFriendlyWith(snake);

            Assert.False(isFriendlyWithLions);
            Assert.False(isFriendlyWithPenguins);
            Assert.False(isFriendlyWithSnakes);
        }
    }
}
