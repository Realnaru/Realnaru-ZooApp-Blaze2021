using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class HireValidatorProvaiderTests
    {
        [Fact]
        public void ShouldBeAbleToCreateHireValidatorProvider()
        {
            HireValidatorProvider hireValidatorProvider= new();
        }

        [Fact]
        public void ShouldBeAbleToGetHireValidator()
        {
            HireValidatorProvider hireValidatorProvider = new();
            IEmployee zooKeeper = new ZooKeeper("First Name", "LastName");
            IHireValidator hireValidator = hireValidatorProvider.GetHireValidator(zooKeeper);

            IEmployee veterinarian = new Veterinarian("First Name", "Last Name");
            IHireValidator anotherHireValidator = hireValidatorProvider.GetHireValidator(veterinarian);
        }

        [Fact]
        public void ShouldThrowExeptionIfWrongEmployee()
        {
            HireValidatorProvider hireValidatorProvider = new();
            IEmployee testEmployee = new TestEmployee();
            Assert.Throws<Exception>(() => hireValidatorProvider.GetHireValidator(testEmployee));
        }

    }
}
