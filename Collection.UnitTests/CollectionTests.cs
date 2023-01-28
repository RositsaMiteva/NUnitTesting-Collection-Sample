

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





    }
}