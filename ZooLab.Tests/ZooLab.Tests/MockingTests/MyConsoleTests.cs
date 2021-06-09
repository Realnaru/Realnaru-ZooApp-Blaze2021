using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class MyConsoleTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZooConsole()
        {
            MockConsole zooConsole = new();
        }

        [Fact]
        public void ShouldBeAbleToAddMessages()
        {
            MockConsole zooConsole = new();
            zooConsole.WriteLine("Some text");
            Assert.Equal("Some text", zooConsole.Log[0]);
        }
    }

}
