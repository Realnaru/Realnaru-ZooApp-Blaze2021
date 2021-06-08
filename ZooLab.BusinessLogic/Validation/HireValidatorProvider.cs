using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class HireValidatorProvider 
    {
        public IHireValidator GetHireValidator(IEmployee employee)
        {
            if (employee.GetType().Name == typeof(ZooKeeper).Name)
            {
                return new ZooKeeperHireValidator();
            }
            if (employee.GetType().Name == typeof(Veterinarian).Name)
            {
                return new VeterinarianHireValidator();
            }
            throw new Exception();
        }
    }
}
