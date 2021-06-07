using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class AnimalsTests
    {
        [Fact]
        public void ShouldBeAbleToSetAndGetId()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.Id = 1;
            elephant.Id = 2;
            bison.Id = 3;
            penguin.Id = 4;
            parrot.Id = 5;
            turtle.Id = 6;
            snake.Id = 7;

            int lionId = lion.Id;
            int elephantId = elephant.Id;
            int bisonId = bison.Id;
            int penguinId = penguin.Id;
            int parrotId = parrot.Id;
            int turtleId = turtle.Id;
            int snakeId = snake.Id;

            Assert.Equal(1, lionId);
            Assert.Equal(2, elephantId);
            Assert.Equal(3, bisonId);
            Assert.Equal(4, penguinId);
            Assert.Equal(5, parrotId);
            Assert.Equal(6, turtleId);
            Assert.Equal(7, snakeId);
        }

        [Fact]
        public void ShouldBeAbleToGetNeededMedicineToBeHealed()
        {
            Animal lion = new Lion();
            string neededMedicine = lion.NeededMedicine;
            Assert.Equal(neededMedicine, lion.NeededMedicine);
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetFeedTimes()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.FeedTimes = new List<FeedTime>() { new FeedTime()};
            elephant.FeedTimes = new List<FeedTime>() { new FeedTime()};
            bison.FeedTimes = new List<FeedTime>() { new FeedTime() };
            penguin.FeedTimes = new List<FeedTime>() { new FeedTime() };
            parrot.FeedTimes = new List<FeedTime>() { new FeedTime() };
            turtle.FeedTimes = new List<FeedTime>() { new FeedTime() };
            snake.FeedTimes = new List<FeedTime>() { new FeedTime() };

            List<FeedTime> lionFeedTimes = lion.FeedTimes;
            List<FeedTime> elephantFeedTimes = elephant.FeedTimes;
            List<FeedTime> bisonFeedTimes = bison.FeedTimes;
            List<FeedTime> penguinFeedTimes = penguin.FeedTimes;
            List<FeedTime> parrotFeedTimes = parrot.FeedTimes;
            List<FeedTime> turtleFeedTimes = turtle.FeedTimes;
            List<FeedTime> snakeFeedTimes = snake.FeedTimes;

            Assert.Equal(lionFeedTimes, lion.FeedTimes);
            Assert.Equal(elephantFeedTimes, elephant.FeedTimes);
            Assert.Equal(bisonFeedTimes, bison.FeedTimes);
            Assert.Equal(penguinFeedTimes, penguin.FeedTimes);
            Assert.Equal(parrotFeedTimes, parrot.FeedTimes);
            Assert.Equal(turtleFeedTimes, turtle.FeedTimes);
            Assert.Equal(snakeFeedTimes, snake.FeedTimes);
        }

        [Fact]
        public void ShouldBeAbleToGetSickState()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.IsSick = false;
            elephant.IsSick = false;
            bison.IsSick = false;
            penguin.IsSick = false;
            parrot.IsSick = false;
            turtle.IsSick = false;
            snake.IsSick = false;

            bool isLionSick = lion.IsSick;
            bool isElephantSick = elephant.IsSick;
            bool isBisonSick = bison.IsSick;
            bool isPenguinSick = penguin.IsSick;
            bool isParrotSick = parrot.IsSick;
            bool isTurtleSick = turtle.IsSick;
            bool isSnakeSick = snake.IsSick;

            Assert.False(isLionSick);
            Assert.False(isElephantSick);
            Assert.False(isBisonSick);
            Assert.False(isPenguinSick);
            Assert.False(isParrotSick);
            Assert.False(isTurtleSick);
            Assert.False(isSnakeSick);
        }

        
        [Fact]
        public void ShouldBeAbleToBeHungryAndBeFed()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.IsHungry = true;
            elephant.IsHungry = true;
            bison.IsHungry = true;
            penguin.IsHungry = true;
            parrot.IsHungry = true;
            turtle.IsHungry = true;
            snake.IsHungry = true;

            lion.Feed(new Meat());
            elephant.Feed(new Grass());
            bison.Feed(new Grass());
            penguin.Feed(new Meat());
            parrot.Feed(new Vegetable());
            turtle.Feed(new Vegetable());
            snake.Feed(new Meat());

            Assert.False(lion.IsHungry);
            Assert.False(elephant.IsHungry);
            Assert.False(bison.IsHungry);
            Assert.False(penguin.IsHungry);
            Assert.False(parrot.IsHungry);
            Assert.False(turtle.IsHungry);
            Assert.False(snake.IsHungry);   
        }

        [Fact]
        public void ShouldNotBecomeFedIfFoodIsUnfaivorite()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.IsHungry = true;
            elephant.IsHungry = true;
            bison.IsHungry = true;
            penguin.IsHungry = true;
            parrot.IsHungry = true;
            turtle.IsHungry = true;
            snake.IsHungry = true;

            lion.Feed(new Vegetable());
            elephant.Feed(new Meat());
            bison.Feed(new Meat());
            penguin.Feed(new Grass());
            parrot.Feed(new Meat());
            turtle.Feed(new Meat());
            snake.Feed(new Vegetable());

            Assert.True(lion.IsHungry);
            Assert.True(elephant.IsHungry);
            Assert.True(bison.IsHungry);
            Assert.True(penguin.IsHungry);
            Assert.True(parrot.IsHungry);
            Assert.True(turtle.IsHungry);
            Assert.True(snake.IsHungry);
        }


        [Fact]
        public void shouldBeAbleToAddAndGetFeedSchedule()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            List<int> lionFeedSchedule = new List<int>() { 1, 2 };
            List<int> elephantFeedSchedule = new List<int>() { 2, 3 };
            List<int> bisonFeedSchedule = new List<int>() { 3, 4 };
            List<int> penguinFeedSchedule = new List<int>() { 4, 5 };
            List<int> parrotFeedSchedule = new List<int>() { 5, 6 };
            List<int> turtleFeedSchedule = new List<int>() { 7, 8 };
            List<int> snakeFeedSchedule = new List<int>() { 8, 9 };

            lion.AddFeedSchedule(lionFeedSchedule);
            elephant.AddFeedSchedule(elephantFeedSchedule);
            bison.AddFeedSchedule(bisonFeedSchedule);
            penguin.AddFeedSchedule(penguinFeedSchedule);
            parrot.AddFeedSchedule(parrotFeedSchedule);
            turtle.AddFeedSchedule(turtleFeedSchedule);
            snake.AddFeedSchedule(snakeFeedSchedule);

            Assert.Equal(lionFeedSchedule, lion.FeedSchedule);
            Assert.Equal(elephantFeedSchedule, elephant.FeedSchedule);
            Assert.Equal(bisonFeedSchedule, bison.FeedSchedule);
            Assert.Equal(penguinFeedSchedule, penguin.FeedSchedule);
            Assert.Equal(parrotFeedSchedule, parrot.FeedSchedule);
            Assert.Equal(turtleFeedSchedule, turtle.FeedSchedule);
            Assert.Equal(snakeFeedSchedule, snake.FeedSchedule);
        }

        [Fact]
        public void ShouldBeAbleToBeHealed()
        {
            Animal lion = new Lion();
            Animal elephant = new Elephant();
            Animal bison = new Bison();
            Animal penguin = new Penguin();
            Animal parrot = new Parrot();
            Animal turtle = new Turtle();
            Animal snake = new Snake();

            lion.Heal(new Antibiotic());
            elephant.Heal(new Antibiotic());
            bison.Heal(new AntiInflammatory());
            penguin.Heal(new AntiDepression());
            parrot.Heal(new AntiDepression());
            turtle.Heal(new Antibiotic());
            snake.Heal(new AntiInflammatory());
        }
    }
}
