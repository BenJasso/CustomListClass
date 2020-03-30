using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListClassTests
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]//1
        public void Add_CheckCount_AddNegativeNumber()
        {
           // arrange
            
            ListB<int> listB = new ListB<int>();
            int value = -3;
            int expected = 1;
            int actual;

            //act
            listB.Add(value);
            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//2
        public void Add_CheckCount_AddPositiveNumber()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int value = 23;
            int expected = 1;
            int actual;

            //act
            listB.Add(value);
            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//3
        public void Add_CheckIfNewArrayIsMade_Add5thElement()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int value = 23;
            int expected = 8;
            int actual;

            //act
            listB.Add(value);
            listB.Add(value + 10);
            listB.Add(value + 20);
            listB.Add(value + 15);
            listB.Add(value + 32);
            actual = listB.Capacity;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//4
        public void Add_CheckListCount_Add5thElement()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int value = 23;
            int expected = 5;
            int actual;

            //act
            listB.Add(value);
            listB.Add(value + 10);
            listB.Add(value + 20);
            listB.Add(value + 15);
            listB.Add(value + 32);
            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//5
        public void Add_CheckArrayOrderStayedSame_Add5thElement()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int value = 23;
            int expected = value + 20;
            int actual;

            //act
            listB.Add(value);
            listB.Add(value + 10);
            listB.Add(value + 20);
            listB.Add(value + 15);
            listB.Add(value + 32);
            actual = listB.ElementAt(2);


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
