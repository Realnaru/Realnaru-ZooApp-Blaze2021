using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public interface IHireValidator
    {
        List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
