using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShelterManager;

namespace UnitTestProject
{
    [TestClass]
    public class ShelterClassTest
    {
        [TestMethod]
        public void TestGettingAnimalByRFID()
        {
            //Arrange
            Shelter s = new Shelter("TestShelter", "Test Address", "Test@Email", "TestPhone");
            Dog d1 = new Dog(DateTime.Now, "TestLocation", "TestDescription", "1234abc");
            Cat c1 = new Cat(DateTime.Now, "TestLocation2", "TestDescription2", "123abcd", "TestInfo");
            s.AddAnimal(d1);
            s.AddAnimal(c1);

            //Act
            Dog checkDog = (Dog)s.GetByRFID("1234abc");
            Cat checkCat = (Cat)s.GetByRFID("123abcd");
            Animal checkAnimal = s.GetByRFID("IDontExist");

            //Assert
            Assert.AreEqual(d1, checkDog);
            Assert.AreEqual(c1, checkCat);
            Assert.AreEqual(null, checkAnimal);
        }


        [TestMethod]
        public void TestAddAnimal()
        {

            Shelter s = new Shelter("TestShelter", "Test Address", "Test@Email", "TestPhone");
            Dog dog = new Dog(DateTime.Now, "TestL", "TestDesc", "1234abc");
            Cat cat = new Cat(DateTime.Now, "TestLocation", "TestDescription", "123abcd", "TestInfo");
            Dog dupeDog = new Dog(DateTime.Now, "TestLocation", "TestDesc", "1234abc"); //Duplicate RFID

            //Act
            bool checkDog = s.AddAnimal(dog);
            bool checkCat = s.AddAnimal(cat);
            bool checkDupe = s.AddAnimal(dupeDog);

            //Assert
            Assert.AreEqual(true, checkDog);
            Assert.AreEqual(true, checkCat);

            Assert.AreEqual(false, checkDupe);
            Assert.AreEqual(dog, s.GetByRFID("1234abc"));  //Check that the RFID is only for the first
        }

        [TestMethod]

        public void TestGetOwner()
        {
            //Arrange
            DateTime date1 = new DateTime(2019, 1, 1);
            Shelter s = new Shelter("TestShelter", "Test Address", "Test@Email", "TestPhone");
            Owner own1 = new Owner("1", "Stefans");
            Dog animal1 = new Dog(DateTime.Now, "1234 playground stret", "Description", "1234abcd");
            animal1.Adopt(own1);
            Dog dog = new Dog(date1, "TestL", "TestDesc", "1234abc");
            s.AddAnimal(dog);
            s.AddOwner(own1);
            dog.Adopt(own1);

            //Act
            Owner checkowner = dog.GetOwner();

            //Assert
            Assert.AreEqual(own1, checkowner);

        }
        [TestMethod]
        public void TestClaimAnimal()
        {
            //Arrange
            DateTime date1 = new DateTime(2019, 1, 1);
            
            Shelter shelter = new Shelter("TestShelter", "Test Address", "Test@Email", "TestPhone");
            Dog dog = new Dog(date1, "TestLocation", "TestDescription", "1234abc");
            Dog dogfail = new Dog(DateTime.Now, "TestL", "TestD", "12ab");
            Owner owner = new Owner("1", "TestOwner");
            double amountDays = (DateTime.Today - dog.GetFoundDate()).TotalDays;
            double payAmount = 10+2*amountDays;
            shelter.AddAnimal(dog);
            shelter.AddOwner(owner);
            dog.Adopt(owner);
            dog.checkIn();

            //Act
            double check = dog.Claim(owner);
            double checkfail = dog.Claim(owner);

            //Assert
            
            Assert.AreEqual(payAmount, check);
            Assert.AreEqual(-1, checkfail);
        }

    }
}
