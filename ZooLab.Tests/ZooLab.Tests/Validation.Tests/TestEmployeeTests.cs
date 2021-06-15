using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ZooLab.Tests.Validation.Tests
{
    public class TestEmployeeTests
    {

    [Fact]
    public void ShouldBeAbleToCreateTestEmployee()
        {
            TestEmployee testEmployee = new();
        }

        [Fact]
        public void ShouldBeAbleToGetNames()
        {
            TestEmployee testEmployee = new();
            string name = testEmployee.FirstName;
            string lastName = testEmployee.LastName;
            
        }
    }
}
