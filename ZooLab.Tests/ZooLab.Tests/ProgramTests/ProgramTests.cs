using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ProgramTests
    {
     
        [Fact]
        public void ShouldReturnMessages()
        {
            MockConsole mockConsole = new();

            List<string> messages =  Program.RunZoo(mockConsole);

            Assert.Equal(48, messages.Count);

        }
    }
}
