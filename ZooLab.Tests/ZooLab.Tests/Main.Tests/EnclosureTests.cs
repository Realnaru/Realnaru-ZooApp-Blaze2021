using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.BusinessLogic;

namespace ZooLab.Tests
{
    public class EnclosureTests
    {
        [Fact]
        public void ShoulBeAbleToCreateEnclosure()
        {
            Enclosure enclosure = new Enclosure();

        }

        [Fact]
        public void ShoulBeAbleToCreateEnclosureWithNameAndArea()
        {
            Enclosure enclosure = new Enclosure("anyName", 5);
        }

        [Fact]
        public void ShoulBeAbleToGetName()
        {
            Enclosure enclosure = new Enclosure();
            string anyName = enclosure.Name;
        }

        [Fact]
        public void ShoulBeAbleToGetAnimals()
        {
            Enclosure enclosure = new Enclosure();
            List<Animal> animals = enclosure.Animals; 
        }

        [Fact]
        public void ShoulBeAbleToGetParentZoo()
        {
            Enclosure enclosure = new Enclosure();
            Zoo anyZoo = enclosure.ParentZoo;
        }

        [Fact]
        public void ShoulBeAbleToGetSquareFeet()
        {
            Enclosure enclosure = new Enclosure();
            int anyArea = enclosure.SquareFeet;
        }

        /*
        [Fact]
        public void ShoulBeAbleToAddFriendlyAnimals()
        {
            Enclosure enclosure = new Enclosure("Huge Enclosure", 100000000);
            Animal firstBird = new Parrot();
            Animal secondBird = new Penguin();
            Animal firstMammal = new Bison();
            Animal secondMammal = new Elephant();
            Animal thirdMammal = new Lion();
            Animal firstReptile = new Snake();
            Animal secondReptile = new Turtle();

            List<Animal> animals = new List<Animal>() { firstBird, secondBird, firstMammal, secondMammal, thirdMammal, firstReptile, secondReptile };
            foreach (var animal in animals)
            {
                enclosure.AddAnimals(animal);
            }

            List<Animal> receivedAnimals = enclosure.Animals;
            Assert.Equal(animals, receivedAnimals); 
            
       
        }
        */
    }
}
