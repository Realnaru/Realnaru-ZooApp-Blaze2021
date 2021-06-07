using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class GrassTests
    {
        [Fact]
        public void ShoulBeAbleToCreateGrass()
        {
            Grass grass = new();
        }
    }
}
