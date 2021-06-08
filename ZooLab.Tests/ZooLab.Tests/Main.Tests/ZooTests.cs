﻿using System;
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
        public void ShouldNotBeAbleToHireEmployeeWithoutExpirience()
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
        public void ShouldBeAbleToHireExpiriencedEmployee()
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
    }
}
