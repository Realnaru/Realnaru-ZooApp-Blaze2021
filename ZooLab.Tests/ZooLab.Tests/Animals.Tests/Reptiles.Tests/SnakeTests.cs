using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class SnakeTests
    {
        [Fact]
        public void ShoulBeAbleToCreateSnake()
        {
            Snake snake = new();
        }

        [Fact]
        public void ShouldRequire2sqFeet()
        {
            Snake snake = new();
            int requiredArea = snake.RequiredSpaceSqFeet;
            Assert.Equal(2, requiredArea);
        }

        [Fact]
        public void ShouldBeAbleToGetFavoriteFood()
        {
            Snake snake = new();
            List<string> food = snake.FavoriteFood.ToList<string>();
        }

        [Fact]
        public void ShouldBeFriendlyWithSnakes()
        {
            Snake firstSnake = new();
            Snake secondSnake = new();

            bool isFriendlyWithSnakes = firstSnake.IsFriendlyWith(secondSnake);

            Assert.True(isFriendlyWithSnakes);
        }

        [Fact]
        public void ShouldNotBeFriendlyWithOtherAnimals()
        {
            Snake snake = new();
            Lion lion = new();
            Elephant elephant = new();
            Bison bison = new();
            Penguin penguin = new();
            Parrot parrot = new();
            Turtle turtle = new();

            bool isFriendlyWithLions = snake.IsFriendlyWith(lion);
            bool isFriendlyWithElephants = snake.IsFriendlyWith(elephant);
            bool isFriendlyWithBisons = snake.IsFriendlyWith(bison);
            bool isFriendlyWithPenguins = snake.IsFriendlyWith(penguin);
            bool isFriendlyWithParrots = snake.IsFriendlyWith(parrot);
            bool isFriendlyWithTurtles = snake.IsFriendlyWith(turtle);

            Assert.False(isFriendlyWithLions);
            Assert.False(isFriendlyWithElephants);
            Assert.False(isFriendlyWithBisons);
            Assert.False(isFriendlyWithParrots);
            Assert.False(isFriendlyWithTurtles);
        }
    }


}
