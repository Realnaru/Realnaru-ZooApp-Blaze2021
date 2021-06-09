using System;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ZooAppTests
    {
        [Fact]
        public void ShoulBeAbleToCreateZooApp()
        {
            ZooApp zooApp = new ZooApp();

        }

        [Fact]
        public void ShoulBeAbleToAddZoo()
        {
            ZooApp zooApp = new ZooApp();
            zooApp.AddZoo(new Zoo());

        }
    }
}
