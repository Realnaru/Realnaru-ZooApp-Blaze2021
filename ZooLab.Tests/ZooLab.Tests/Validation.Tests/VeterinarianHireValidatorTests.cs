using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

 namespace ZooLab.Tests
{
    public class VeterinarianHireValidatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateVeterinarianHireValidator()
        {
            VeterinarianHireValidator veterinarianHireValidator = new();
        }

        [Fact]
        public void ShouldBeAbleToValidateEmployeeZsVeterainarian()
        {
            Zoo zoo = new Zoo();
            VeterinarianHireValidator veterinarianHireValidator = new();
            IEmployee employee = new Veterinarian("First Name", "Last Name");
            List<ValidationError> errors = veterinarianHireValidator.ValidateEmployee(employee, zoo);
        }





    }
}
