

using Collections;
using NUnit.Framework;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
       
        [Test]

        public void Test_Collection_EmptyConstructor() 
        {
            //Arrange and Act
            var coll = new Collection<int>();
            Assert.AreEqual(coll.ToString(), "[]");
        }
        [Test]
        public void Test_Collection_ConstructorSingleItem() 
        {
            var coll = new Collection<int>(5);
            //Assert
            Assert.AreEqual(coll.ToString(), "[5]");
        }
        [Test]
        public void Test_Collection_ConstructorMultipleItems() 
        {
            var coll = new Collection<int>(2, 2);
            //Assert
            Assert.AreEqual(coll.ToString(), "[2, 2]");
        }
        [Test]
        public void Test_Collection_Add() 
        {
            //Arrange
            var coll = new Collection<int>();
            //Act
            coll.Add(5);
            coll.Add(6);
            //Assert
            Assert.That(coll.ToString(), Is.EqualTo("[5, 6]"));
        }
        [Test]
        public void Test_Collection_AddRangeWithGrow() 
        {
            //Arrange
            var coll = new Collection<int>();
            //Act
            coll.AddRange(5 + 5);
            //Assert
            Assert.That(coll.ToString(), Is.EqualTo("[10]"));
        }
         [Test]
        public void Test_Collection_GetByIndex() 
        {
            // Arrange
            var names = new Collection<string>("Peter", "Maria");
            // Act
            var item0 = names[0];
            var item1 = names[1];
            // Assert
            Assert.That(item0, Is.EqualTo("Peter"));
            Assert.That(item1, Is.EqualTo("Maria"));

        }






    }
}