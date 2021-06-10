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
        public void ShouldBeAbleToCreateEnclosureWithNameAreaAndParentZoo()
        {
            Enclosure enclosure = new Enclosure(new Zoo(),"anyName", 5);

        }

        [Fact]
        public void ShouldBeAbleToGetName()
        {
            Enclosure enclosure = new Enclosure(new Zoo(), "Some name", 1000);
            string anyName = enclosure.Name;
        }

        [Fact]
        public void ShouldBeAbleToGetAnimals()
        {
            Enclosure enclosure = new Enclosure(new Zoo(), "Some name", 1000);
            List<Animal> animals = enclosure.Animals; 
        }

        [Fact]
        public void ShouldBeAbleToGetParentZoo()
        {
            Enclosure enclosure = new Enclosure(new Zoo(), "Some name", 1000);
            Zoo anyZoo = enclosure.ParentZoo;
        }

        [Fact]
        public void ShouldBeAbleToGetSquareFeet()
        {
            Enclosure enclosure = new Enclosure(new Zoo(), "Some name", 1000);
            int anyArea = enclosure.SquareFeet;
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalsIfThereIsSpaceAndNoUnfriendlyAnimals()
        {
            Enclosure enclosure = new(new Zoo(),"huge enclosure", 100000);
            Elephant elephant = new Elephant();
            enclosure.AddAnimals(elephant);
            Assert.Equal(elephant, enclosure.Animals[0]);
        }

        [Fact]
        public void ShouldBeAbleToTagAddedAnimal()
        {
            Zoo parentZoo = new();
            Enclosure enclosure = new(parentZoo, "huge enclosure", 100000);
            Elephant elephant = new Elephant();
            enclosure.AddAnimals(elephant);
            Assert.Equal(1, elephant.Id);
        }

        [Fact]
        public void ShouldBeNotAbleToAddAnimalsIfThereIsNoSpace()
        {
            Enclosure enclosure = new(new Zoo(), "tiny enclosure", 5);
            Elephant elephant = new Elephant();
            Assert.Throws<NoAvailableSpaceException>(() => enclosure.AddAnimals(elephant));
        }

        [Fact]
        public void ShouldBeNotAbleToAddAnimalsIfThereIsUnfriendlyAnimal()
        {
            Enclosure enclosure = new(new Zoo(), "huge enclosure", 10000);
            enclosure.AddAnimals(new Lion());
            Elephant elephant = new Elephant();
            Assert.Throws<NotFriendlyAnimalException>(() => enclosure.AddAnimals(elephant));
        }

        [Fact]
        public void ShouldBeAbleToDecideIsEnclosureSafeForAnimal()
        {
            Enclosure firstEnclosure = new(new Zoo(), "huge enclosure", 10000);
            firstEnclosure.AddAnimals(new Lion());
            bool isFriendlyToBison = firstEnclosure.IsFriendlyTo(new Bison());
            Assert.False(isFriendlyToBison);

            Enclosure secondEnclosure = new(new Zoo(), "big enclosure", 9000);
            secondEnclosure.AddAnimals(new Bison());
            bool isFriendlyToAnotherBison = secondEnclosure.IsFriendlyTo(new Bison());
            Assert.True(isFriendlyToAnotherBison);

        }

        [Fact]
        public void ShouldAddAnimalExpirienceToZooKeepersThenNewAnimalISAddedToZoo()
        {
            Zoo zoo = new();
            ZooKeeper zooKeeper = new("", "");
            zoo.Employees.Add(zooKeeper);
            zoo.Enclosures.Add(new Enclosure(zoo, "", 10000));
            Lion lion = new();
            Enclosure enclosureForLion = zoo.FindAvailableEnclosure(lion);
            enclosureForLion.AddAnimals(lion);
            Assert.Equal(zooKeeper.AnimalExperience[0], lion.GetType().Name);
        }

    }
}
