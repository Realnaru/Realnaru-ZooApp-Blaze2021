using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class ZooTests
    {
        [Fact]
        public void ShoulBeAbleToCreateZoo()
        {
            Zoo zoo = new Zoo();
        }

        [Fact]
        public void ShoulBeAbleToGetIdForAnimals()
        {
            Zoo zoo = new Zoo();
            Assert.Equal(1, zoo.StartingId);

        }

        [Fact]
        public void ShoulBeAbleToCreateZooWithLocation()
        {
            Zoo zoo = new Zoo("San-Diego");
        }

        [Fact]
        public void ShoulBeAbleToGetEnclosures()
        {
            Zoo zoo = new Zoo();
            List<Enclosure> enclosures = zoo.Enclosures;
            Assert.Equal(enclosures, zoo.Enclosures);
        }

        [Fact]
        public void ShoulBeAbleToGetEmployees()
        {
            Zoo zoo = new Zoo();
            List<IEmployee> employees = zoo.Employees;
            Assert.Equal(employees, zoo.Employees);
        }

        [Fact]
        public void ShoulBeAbleToGetLocation()
        {
            Zoo zoo = new Zoo();
            string zooLoczation = zoo.Location;
        }

        [Fact]
        public void ShoulBeAbleToAddLocation()
        {
            Zoo zoo = new Zoo();
            string location = "Some place";
            zoo.AddLocation(location);
            Assert.Equal(location, zoo.Location);
        }

        [Fact]
        public void ShoulBeAbleToAddEnclosure()
        {
            Zoo zoo = new Zoo();
            zoo.AddEnclosure("Lions Enclosure", 5000);

            Enclosure enclosure = zoo.Enclosures[0];
            string enclosureName = enclosure.Name;
            int enclosureArea = enclosure.SquareFeet;

            Assert.Equal("Lions Enclosure", enclosureName);
            Assert.Equal(5000, enclosureArea);
        }

        
        [Fact]
        public void ShoulBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo();
            Lion lion = new Lion();
            zoo.AddEnclosure("enclosure for lion", 10000);
            Enclosure enclosureForLion = zoo.FindAvailableEnclosure(lion);
            Assert.Equal(enclosureForLion, zoo.Enclosures[0]);
            enclosureForLion.AddAnimals(lion);
            Assert.Single(enclosureForLion.Animals);
            
        }
        
        [Fact]
        public void ShouldThrowExeptionIfEnclosureNotFound()
        {
            Zoo zoo = new();
            Lion lion = new();
            
            Assert.Throws<NoAvailableEnclosureException>( () => {
                zoo.FindAvailableEnclosure(lion);});
        }

        [Fact]
        public void ShouldNotBeAbleToHireZooKeeperWithoutExpirience()
        {
            Zoo zoo = new();

            zoo.AddEnclosure("new enclosure", 10000);

            Elephant elephant = new Elephant();

            Enclosure newEnclousure = zoo.FindAvailableEnclosure(elephant);

            newEnclousure.AddAnimals(elephant);

            IEmployee zooKeeper = new ZooKeeper("First Name", "Last Name");

            Assert.Throws<NoNeededExpirienceException>(() => zoo.HireEmployee(zooKeeper));
            
        }

        [Fact]
        public void ShouldNotBeAbleToHireVeterinarianWithoutExpirience()
        {
            Zoo zoo = new();

            zoo.AddEnclosure("new enclosure", 10000);
            zoo.AddEnclosure("another enclosure", 10000);

            Elephant elephant = new Elephant();
            Bison bison = new();

            Enclosure newEnclousure = zoo.FindAvailableEnclosure(elephant);

            Enclosure anotherEnclousure = zoo.FindAvailableEnclosure(bison);

            newEnclousure.AddAnimals(elephant);

            anotherEnclousure.AddAnimals(bison);

            Veterinarian veterinarian = new Veterinarian("First Name", "Last Name");
            veterinarian.AddAnimalExperience(new Elephant());

            Assert.Throws<NoNeededExpirienceException>(() => zoo.HireEmployee(veterinarian));

        }

        [Fact]
        public void ShouldBeAbleToHireExpiriencedZooKeeper()
        {
            Zoo zoo = new();
            Bison bison = new Bison();
            zoo.AddEnclosure("new enclosure", 10000);
            Enclosure newEnclosure = zoo.FindAvailableEnclosure(bison);
            newEnclosure.AddAnimals(bison);
            ZooKeeper zooKeeper = new("First Name", "Last Name");
            zooKeeper.AddAnimalExperience(new Bison());
            zoo.HireEmployee(zooKeeper);
            Assert.Equal(zooKeeper, zoo.Employees[0]);
        }

        [Fact]
        public void ShouldBeAbleToHireExpiriencedVeterinarian()
        {
            Zoo zoo = new();
            Bison bison = new Bison();
            zoo.AddEnclosure("new enclosure", 10000);
            Enclosure newEnclosure = zoo.FindAvailableEnclosure(bison);
            newEnclosure.AddAnimals(bison);
            Veterinarian veterinarian = new("First Name", "Last Name");
            veterinarian.AddAnimalExperience(new Bison());
            zoo.HireEmployee(veterinarian);
            Assert.Equal(veterinarian, zoo.Employees[0]);
        }

        [Fact]
        public void ShouldBeAbleToFeedAllAnimals()
        {
            Zoo zoo = new();

            zoo.AddEnclosure("Lions enclosure", 10000);
            zoo.AddEnclosure("Elephants enclosure", 10000);

            Lion lion = new();
            Elephant elephant = new();

            ZooKeeper zooKeeper = new("John", "Doe");
            zooKeeper.AvailableFood.Add(new Grass());
            zooKeeper.AvailableFood.Add(new Vegetable());
            zooKeeper.AvailableFood.Add(new Meat());
            zooKeeper.AddAnimalExperience(lion);
            zooKeeper.AddAnimalExperience(elephant);

            zoo.HireEmployee(zooKeeper);

            lion.IsHungry = true;
            elephant.IsHungry = true;

            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);

            zoo.FeedAnimals();

            Assert.False(lion.IsHungry);
            Assert.False(elephant.IsHungry);
        }

        [Fact]
        public void ShouldBeAbleToHealAllAnimals()
        {
            Zoo zoo = new();

            zoo.AddEnclosure("Lions enclosure", 10000);
            zoo.AddEnclosure("Elephants enclosure", 10000);

            Lion lion = new();
            Elephant elephant = new();

            Veterinarian veterinarian = new("John", "Doe");

            veterinarian.AvailableMedicine.Add(new Antibiotic());
            veterinarian.AvailableMedicine.Add(new AntiDepression());
            veterinarian.AvailableMedicine.Add(new AntiInflammatory());
            veterinarian.AddAnimalExperience(lion);
            veterinarian.AddAnimalExperience(elephant);

            zoo.HireEmployee(veterinarian);

            lion.IsSick = true;
            elephant.IsSick = true;

            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);

            zoo.HealAnimals();

            Assert.False(lion.IsSick);
            Assert.False(elephant.IsSick);
        }

        [Fact]
        public void ShouldThrowExceptionIfThereIsAreZooKeepersHired()
        {
            Zoo zoo = new();
            zoo.Employees.Add(new Veterinarian("",""));

            Assert.Throws<NoNeededEmployeeException>(() => zoo.FeedAnimals());
        }

        [Fact]
        public void ShouldThrowExceptionIfThereIsAreNoVeterinariansHired()
        {
            Zoo zoo = new();
            zoo.Employees.Add(new ZooKeeper("", ""));

            Assert.Throws<NoNeededEmployeeException>(() => zoo.HealAnimals());
        }

        [Fact]
        public void ShouldThrowExceptionIfThereIsAreNoEmployeesThenTryingToFeedAnimals()
        {
            Zoo zoo = new();
            Assert.Throws<NoEmployeesException>(() => zoo.FeedAnimals());
        }

        [Fact]
        public void ShouldThrowExceptionIfThereIsAreNoEmployeesThenTryingToHealAnimals()
        {
            Zoo zoo = new();
            Assert.Throws<NoEmployeesException>(() => zoo.HealAnimals());
        }

        [Fact]
        public void ShouldDivideAnimalsWhenThereAreMoreThanOneZooKeeper()
        {
            Zoo zoo = new();
            zoo.AddEnclosure("", 10000);

            Elephant elephant = new();
            Bison bison = new();

            elephant.IsHungry = true;
            bison.IsHungry = true;

            Enclosure enclosureOne = zoo.FindAvailableEnclosure(elephant);
            Enclosure enclosureTwo = zoo.FindAvailableEnclosure(bison);

            enclosureOne.AddAnimals(elephant);
            enclosureOne.AddAnimals(bison);

            ZooKeeper firstZooKeeper = new("", "");
            ZooKeeper secondZooKeeper = new("first", "last");

            firstZooKeeper.AddAnimalExperience(new Elephant());
            firstZooKeeper.AddAnimalExperience(new Bison());

            secondZooKeeper.AddAnimalExperience(new Elephant());
            secondZooKeeper.AddAnimalExperience(new Bison());

            firstZooKeeper.AvailableFood.Add(new Grass());
            secondZooKeeper.AvailableFood.Add(new Grass());


            zoo.Employees.Add(firstZooKeeper);
            zoo.Employees.Add(secondZooKeeper);

            zoo.FeedAnimals();

            //Assert.Equal(firstZooKeeper, elephant.FeedTimes[0].FedByZookeeper);
            Assert.Equal(secondZooKeeper, bison.FeedTimes[0].FedByZookeeper);

        }
<<<<<<< HEAD

        [Fact]
        public void ShouldBeAbleToFeedAnimalsIfThereAreNotOnlyZooKeepers()
        {
            Zoo zoo = new();
            zoo.AddEnclosure("", 10000);

            Elephant elephant = new();
            Bison bison = new();

            elephant.IsHungry = true;
            bison.IsHungry = true;

            Enclosure enclosureOne = zoo.FindAvailableEnclosure(elephant);
            Enclosure enclosureTwo = zoo.FindAvailableEnclosure(bison);

            enclosureOne.AddAnimals(elephant);
            enclosureOne.AddAnimals(bison);

            ZooKeeper zooKeeper = new("first", "first");
            Veterinarian veterinarian = new("second", "second");
            Veterinarian secondVeterinarian = new("second1", "second1");

            zooKeeper.AddAnimalExperience(new Elephant());
            zooKeeper.AddAnimalExperience(new Bison());

            zooKeeper.AvailableFood.Add(new Grass());
            
            zoo.Employees.Add(zooKeeper);
            zoo.Employees.Add(veterinarian);
            zoo.Employees.Add(secondVeterinarian);

            zoo.FeedAnimals();

            Assert.Equal(zooKeeper, bison.FeedTimes[0].FedByZookeeper);

        }

        [Fact]
        public void ShouldBeAbleToHealAllAnimalsIfThereAreNotOnlyVeterinarians()
        {
            Zoo zoo = new();

            zoo.AddEnclosure("Lions enclosure", 10000);
            zoo.AddEnclosure("Elephants enclosure", 10000);

            Lion lion = new();
            Elephant elephant = new();

            ZooKeeper zooKeeper = new("Jein", "Doe");
            Veterinarian veterinarian = new("John", "Doe");
            

            veterinarian.AvailableMedicine.Add(new Antibiotic());
            veterinarian.AvailableMedicine.Add(new AntiDepression());
            veterinarian.AvailableMedicine.Add(new AntiInflammatory());
            veterinarian.AddAnimalExperience(lion);
            veterinarian.AddAnimalExperience(elephant);

            zoo.Employees.Add(zooKeeper);
            zoo.HireEmployee(veterinarian);

            lion.IsSick = true;
            elephant.IsSick = true;

            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);

            zoo.HealAnimals();

            Assert.False(lion.IsSick);
            Assert.False(elephant.IsSick);
        }

=======
>>>>>>> 723fdfbf5ef7a403eb33eb9b020bc4979ea3cf1b
    }
}
