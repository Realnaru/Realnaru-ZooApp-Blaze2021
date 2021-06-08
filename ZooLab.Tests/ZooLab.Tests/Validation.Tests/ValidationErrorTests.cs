using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    
    public class ValidationErrorTests
    {
      
        [Fact]
        public void ShouldBeAbleToCreateValidationErrorWithErrorText()
        {
            ValidationError validationError = new("Error happend!");
        }

        [Fact]
        public void ShouldBeAbleToGetValidationError()
        {
            ValidationError validationError = new("Error happend!");
            string errorMessage = validationError.ErrorMessage;
            Assert.Equal(validationError.ErrorMessage, errorMessage);
        }

    }
}
