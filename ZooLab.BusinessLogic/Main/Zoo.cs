using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Zoo
    {
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();

        public List<IEmployee> Employees { get; private set; } = new List<IEmployee>();

        public string Location { get; private set; }

        public void AddLocation(string anyLocation)
        {
            Location = anyLocation;
        }

        public void AddEnclosure(string name, int area)
        {
            Enclosure enclosure = new Enclosure(name, area);
            Enclosures.Add(enclosure);
        }

        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            foreach (var enclosure in Enclosures)
            {
                if (enclosure.SquareFeet >= animal.RequiredSpaceSqFeet && 
                    enclosure.IsFriendlyTo(animal))
                {
                    return enclosure;
                }
            }
            throw new NoAvailableEnclosureException();
        }

        public void HireEmployee(IEmployee employee)
        {
            HireValidatorProvider validatorProvider = new();
            IHireValidator employeeValidator = validatorProvider.GetHireValidator(employee);
            List <ValidationError> errors = employeeValidator.ValidateEmployee(employee, this);

            if (errors.Count == 0)
            {
                Employees.Add(employee);
            } else
            {
                throw new NoNeededExpirienceException();
            }
        }
            
    }
}
