using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class ValidationError
    {
        public ValidationError(string message)
        {
            ErrorMessage = message;

        }

        public string ErrorMessage { get; }
    }

    
}
