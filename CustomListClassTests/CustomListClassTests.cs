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
            actual = listB[2];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//6
        public void Remove_CheckCount_RemoveOneValue()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 2;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);
            listB.Remove[1];

            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//7
        public void Remove_CheckCount_RemoveMultipleValues()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 2;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);
            listB.Add(2);
            listB.Add(3);
            listB.Add(53);
            listB.Remove[0];
            listB.Remove[4];
            listB.Remove[2]; 
            listB.Remove[5];

            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//8
        public void Remove_CheckIndexOrder_RemoveMiddleValue()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 3;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);
            listB.Add(2);
            listB.Add(3);
            listB.Add(53);
            listB.Remove[3];
           

            actual = listB[3];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//8
        public void Remove_CheckIndexOrder_RemoveMiddleValue()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 3;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);
            listB.Add(2);
            listB.Add(3);
            listB.Add(53);
            listB.Remove[3];


            actual = listB[3];


            //assert
            Assert.AreEqual(expected, actual);
        }
    } 
}
