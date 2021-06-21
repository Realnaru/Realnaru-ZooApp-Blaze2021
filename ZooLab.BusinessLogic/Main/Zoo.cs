﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.BusinessLogic
{
    public class Zoo
    {
        private readonly IConsole zooConsole;
        public Zoo(IConsole console = null)
        {
            zooConsole = console;
            zooConsole?.WriteLine("a Zoo was created without concrete location");
        }
        public Zoo(string location, IConsole console = null)
        {
            Location = location;
            zooConsole = console;
            zooConsole?.WriteLine($"a Zoo was created in {Location}");
        }

        public int StartingId { get; internal set; } = 1;
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();

        public List<IEmployee> Employees { get; private set; } = new List<IEmployee>();

        public string Location { get; private set; }

        public void AddLocation(string anyLocation)
        {
            Location = anyLocation;
            zooConsole?.WriteLine($"The location was changed to {Location} ");
        }

        public void AddEnclosure(string name, int area)
        {
            Enclosure enclosure = new Enclosure(this, name, area);
            Enclosures.Add(enclosure);
            zooConsole?.WriteLine($"An enclousure was created. The enclousure's was set to {enclosure.Name}, it's area is {enclosure.SquareFeet} sq. feet ");
        }

        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            foreach (var enclosure in Enclosures)
            {
                if (enclosure.SquareFeet >= animal.RequiredSpaceSqFeet && 
                    enclosure.IsFriendlyTo(animal))
                {
                    zooConsole?.WriteLine($"Enclosure {enclosure.Name} was found");
                    return enclosure;
                }
            }
            zooConsole?.WriteLine($"There is no available enclosure");
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
                zooConsole?.WriteLine($"{employee.GetType().Name} was hired");
            } else
            {
                zooConsole?.WriteLine($"The employee has no required expirience");
                throw new NoNeededExpirienceException();
            }
        }

        public void FeedAnimals()
        {
            Queue<ZooKeeper> zooKeepers = new Queue<ZooKeeper>();

            if (Employees.Count != 0)
            {
                foreach (var employee in Employees)
                {
                    if (employee.GetType().Name == typeof(ZooKeeper).Name)
                    {
                        zooKeepers.Enqueue(employee as ZooKeeper);
                    }
                }

                if (zooKeepers.Count != 0)
                {
                    foreach (var enclosure in Enclosures)
                    {
                        foreach (var creature in enclosure.Animals)
                        {
                            var zooKeeper = zooKeepers.Dequeue();
                            if (zooKeeper.FeedAnimal(creature))
                            {
                                zooConsole?.WriteLine($"{creature.GetType().Name} was fed by {zooKeeper.FirstName} {zooKeeper.LastName} in {enclosure.Name}");
                            }
                            zooKeepers.Enqueue(zooKeeper);
                        }
                    }

                } else
                {
                    zooConsole?.WriteLine("There are no zookeepers");
                    throw new NoNeededEmployeeException();
                }
            }
            else
            {
                zooConsole?.WriteLine("There are no employees");
                throw new NoEmployeesException();
            }
           

        }

        public void HealAnimals()
        {
            List<Veterinarian> veterinarians = new List<Veterinarian>();

            if (Employees.Count != 0)
            {
                foreach (var employee in Employees)
                {
                    if (employee.GetType().Name == typeof(Veterinarian).Name)
                    {
                        veterinarians.Add(employee as Veterinarian);
                    }
                }

                    if (veterinarians.Count != 0)
                    {
                        foreach (var veterinaran in veterinarians)
                        {
                            foreach (var enclosure in Enclosures)
                            {
                                foreach (var creature in enclosure.Animals)
                                {
                                    if (veterinaran.HasAnimalExperience(creature))
                                    {
                                        if (veterinaran.HealAnimal(creature))
                                        {
                                            zooConsole?.WriteLine($"{creature.GetType().Name} was fed by {veterinaran.FirstName} {veterinaran.LastName} in {enclosure.Name}");
                                        }
                                    }
                                }
                            }
                            break;
                        }
                        
                    } else
                    {
                        zooConsole?.WriteLine($"Zoo has no veterinarian, hire at least one");
                        throw new NoNeededEmployeeException();
                    }
                             
            } else
            {
                zooConsole?.WriteLine($"Zoo has no veterinarian, hire at least one");
                throw new NoEmployeesException();
            }
        }
            
    }
}
