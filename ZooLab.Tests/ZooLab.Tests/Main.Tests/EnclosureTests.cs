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
        public void ShouldBeAbleToCreateEnclosure()
        {
            Enclosure enclosure = new Enclosure();

        }

        [Fact]
        public void ShouldBeAbleToCreateEnclosureWithNameAndArea()
        {
            Enclosure enclosure = new Enclosure("anyName", 5);
        }

        [Fact]
        public void ShouldBeAbleToGetName()
        {
            Enclosure enclosure = new Enclosure();
            string anyName = enclosure.Name;
        }

        [Fact]
        public void ShouldBeAbleToGetAnimals()
        {
            Enclosure enclosure = new Enclosure();
            List<Animal> animals = enclosure.Animals; 
        }

        [Fact]
        public void ShouldBeAbleToGetParentZoo()
        {
            Enclosure enclosure = new Enclosure();
            Zoo anyZoo = enclosure.ParentZoo;
        }

        [Fact]
        public void ShouldBeAbleToGetSquareFeet()
        {
            Enclosure enclosure = new Enclosure();
            int anyArea = enclosure.SquareFeet;
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalsIfThereIsSpaceAndNoUnfriendlyAnimals()
        {
            Enclosure enclosure = new("huge enclosure", 100000);
            Elephant elephant = new Elephant();
            enclosure.AddAnimals(elephant);
            Assert.Equal(elephant, enclosure.Animals[0]);
        }

        [Fact]
        public void ShouldBeNotAbleToAddAnimalsIfThereIsNoSpace()
        {
            Enclosure enclosure = new("tiny enclosure", 5);
            Elephant elephant = new Elephant();
            Assert.Throws<NoAvailableSpaceException>(() => enclosure.AddAnimals(elephant));
        }

        [Fact]
        public void ShouldBeNotAbleToAddAnimalsIfThereIsUnfriendlyAnimal()
        {
            Enclosure enclosure = new("huge enclosure", 10000);
            enclosure.AddAnimals(new Lion());
            Elephant elephant = new Elephant();
            Assert.Throws<NotFriendlyAnimalException>(() => enclosure.AddAnimals(elephant));
        }

        [Fact]
        public void ShouldBeAbleToDecideIsEnclosureSafeForAnimal()
        {
            Enclosure firstEnclosure = new("huge enclosure", 10000);
            firstEnclosure.AddAnimals(new Lion());
            bool isFriendlyToBison = firstEnclosure.IsFriendlyTo(new Bison());
            Assert.False(isFriendlyToBison);

            Enclosure secondEnclosure = new("big enclosure", 9000);
            secondEnclosure.AddAnimals(new Bison());
            bool isFriendlyToAnotherBison = secondEnclosure.IsFriendlyTo(new Bison());
            Assert.True(isFriendlyToAnotherBison);

        }

    }
}
