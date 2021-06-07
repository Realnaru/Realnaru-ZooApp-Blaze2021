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

        /*
        [Fact]
        public void ShoulBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo();
            Lion lion = new Lion();
            zoo.AddEnclosure("Lions Enclosure", 5000);
            zoo.AddEnclosure("elepants Enclosure", 15000);
            zoo.Enclosures[0].AddAnimals(new Lion());
            zoo.Enclosures[1].AddAnimals(new Elephant());
            Enclosure foundEnclosure = zoo.FindAvailableEnclosureFor(lion);
            Enclosure availableEnclosure = zoo.Enclosures[0];
            Assert.Equal(availableEnclosure, foundEnclosure);
        }

        [Fact]
        public void ShouldThrowExeptionIfEnclosureNotFound()
        {
            Zoo zoo = new();
            Lion lion = new();
            
            Assert.Throws<NoAvailableEnclosureException>( () => {
                Enclosure foundEnclosure = zoo.FindAvailableEnclosureFor(lion);
            });
        }
        */
    }
}
