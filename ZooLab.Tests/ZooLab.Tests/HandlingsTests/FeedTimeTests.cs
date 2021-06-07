using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class FeedTimeTests
    {
        [Fact]
        public void ShoulBeAbleToCreateFeedTime()
        {
            FeedTime feedTime = new ();
            
        }

        [Fact]
        public void ShoulBeAbleToGetAndSetFeedTime()
        {
            FeedTime feedTime = new();
            DateTime dateAndTimeToFeed = new DateTime(2021, 6, 6, 15, 46, 00);
            feedTime.TimeToFeed = dateAndTimeToFeed;
            DateTime animalFeedTime = feedTime.TimeToFeed;
            Assert.Equal(dateAndTimeToFeed, animalFeedTime);
        }

        [Fact]
        public void ShoulBeAbleToGetAndSetZookeeper()
        {
            FeedTime feedTime = new();
            ZooKeeper zooKeeper = new("First Name", "Last Name");
            feedTime.FedByZookeeper = zooKeeper;
            ZooKeeper zookeeperThatFedAnimal = feedTime.FedByZookeeper;
            Assert.Equal(zooKeeper, zookeeperThatFedAnimal);
        }
    }
}
