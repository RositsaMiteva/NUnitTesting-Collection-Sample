

using Collections;
using NUnit.Framework;
using System;
using System.Linq;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
        private readonly object coll;

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
        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var coll = new Collection<int>(5, 6);
            Assert.AreEqual(coll.Count, 2, "Chek for Count");
            Assert.That(coll.Capacity, Is.GreaterThan(coll.Count));
        }
        [Test]
        public void TestCollectionGetByIndex()
        {
            var collection = new Collection<int>(10, 20, 30);
            var item = collection[1];

            Assert.That(item.ToString(), Is.EqualTo("20"));
        }
        [Test]
        public void TestCollectionSetByIndex()
        {
            var collection = new Collection<int>(10, 20, 30);
            collection[1] = 222;

            Assert.That(collection.ToString(), Is.EqualTo("[10, 222, 30]"));
        }
        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var names = new Collection<string>("Peter", "Maria");

            Assert.That(() => { var item = names[2]; }, Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void Test_Collection_SetByInvalidIndex()
        {
            var names = new Collection<string>("Peter", "Maria");

            Assert.That(names.ToString(), Is.EqualTo("[Peter, Maria]"));
        }
        [Test]
        public void Test_Collection_1MillionItems()
        {
            const int itemsCount = 1000000;
            var nums = new Collection<int>();
            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray());
            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);
            for (int i = itemsCount - 1; i >= 0; i--)
                nums.RemoveAt(i);
            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);

        }
        [Test]
        public void Test_Collection_Clear()
        {
            var collection = new Collection<int>(15, 20);
            collection.Clear();
            Assert.AreEqual(collection.Count, 0);
            Assert.That(collection.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test_Collection_InsertAtStart()
        {
            var names = new Collection<string>("Petq, Ivan, Gosho");
            names.InsertAt(0,"Sonq");
            Assert.AreEqual(names.ToString(), "[Sonq, Petq, Ivan, Gosho]");
            Assert.That("[Sonq, Petq, Ivan, Gosho]", Is.EqualTo(names.ToString()));

        }

        [Test]
        public void Test_Collection_InsertAtMiddle()
        {
            var collection = new Collection<int>(1, 2, 3, 4);
            collection.InsertAt(1, 200);
            Assert.AreEqual(collection.ToString(), "[1, 200, 2, 3, 4]");
            Assert.That("[1, 200, 2, 3, 4]", Is.EqualTo(collection.ToString()));
        }

        [Test]
        public void Test_Collection_InsertAtEnd()
        {
            var collection = new Collection<int>(15, 16, 17, 18);
            collection.InsertAt(3, 400);
            Assert.AreEqual(collection.ToString(), "[15, 16, 17, 400, 18]");
            Assert.That("[15, 16, 17, 400, 18]", Is.EqualTo(collection.ToString()));
        }
        [Test]
        public void Test_Collection_ExchangeFirstLast()
        {
            var collection = new Collection<int>(200, 300, 400, 500);
            collection.Exchange(0, 3);

            Assert.That(collection[0] == 500);
            Assert.That(collection[3] == 200);
            Assert.That("[500, 300, 400, 200]", Is.EqualTo(collection.ToString()));
        }
        [Test]
        public void Test_Collection_ExchangeMiddle()
        {
            var collection = new Collection<int>(10, 20, 30, 40);
            collection.Exchange(1, 2);

            Assert.That(collection[1] == 30);
            Assert.That(collection[2] == 20);
            Assert.That("[10, 30, 20, 40]", Is.EqualTo(collection.ToString()));
        }

    }

}