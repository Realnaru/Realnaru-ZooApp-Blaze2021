using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class AntiInflammatoryTests
    {
        [Fact]
        public void ShoulBeAbleToCreateAntiInflammatory()
        {
            AntiInflammatory antiInflammatory = new();
        }
    }
}
