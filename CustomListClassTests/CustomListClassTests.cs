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

            int expected = 43;
            int actual = 0;

            //act
            listB.Add(23);
            listB.Add(33);
            listB.Add(43);
            listB.Add(38);
            listB.Add(55);


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
            listB.Remove(12);
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
            listB.Remove(24);
            listB.Remove(3);
            listB.Remove(56);
            listB.Remove(53);
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
            listB.Remove(2);
            actual = listB[3];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//9
        public void Remove_CheckCount_RemoveAllValues()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 0;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);

            listB.Remove(24);
            listB.Remove(12);
            listB.Remove(56);
            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//10
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_CheckForErrorMessage_RemoveValueThatsNotThere()

        {
            // arrange

            ListB<int> listB = new ListB<int>();

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(56);
            listB.Remove(99);


        }

        [TestMethod]//11
        public void Remove_CheckCount_RemoveAValueThatHasADuplicateValue()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 3;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(24);
            listB.Add(33);
            listB.Remove(24);

            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//12
        public void Remove_CheckArrayOrder_RemoveAValueThatHasADuplicateValue()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            int expected = 24;
            int actual;

            //act
            listB.Add(24);
            listB.Add(12);
            listB.Add(24);
            listB.Add(33);

            listB.Remove(24);

            actual = listB[1];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//13
        public void ToString_CheckCoversion_ListOfIntegers()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            string expected = "3456";
            string actual;

            //act
            listB.Add(3);
            listB.Add(4);
            listB.Add(5);
            listB.Add(6);



            actual = listB.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//14
        public void ToString_CheckCoversion_ListOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            string expected = "BenJ";
            string actual;

            //act
            listB.Add("B");
            listB.Add("e");
            listB.Add("n");
            listB.Add("J");



            actual = listB.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//16
        public void OverloadAdditionOfLists_CheckCount_TwoListsOfIntegers()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            ListB<int> listA = new ListB<int>();
            ListB<int> combinedList = new ListB<int>();
            int expected = 8;
            int actual;

            //act
            listB.Add(3);
            listB.Add(9);
            listB.Add(55);
            listA.Add(22);
            listA.Add(23);
            listA.Add(24);
            listA.Add(25);
            listA.Add(26);

            combinedList = listB + listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//17
        public void OverloadAdditionOfLists_CheckCount_TwoListsOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            int expected = 8;
            int actual;

            //act
            listB.Add("B");
            listB.Add("e");
            listB.Add("n");
            listA.Add("j");
            listA.Add("a");
            listA.Add("m");
            listA.Add("i");
            listA.Add("n");

            combinedList = listB + listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//18
        public void OverloadAdditionOfLists_CheckArrayOrderAfterCombining_TwoListsOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            string expected = "m";
            string actual;

            //act
            listB.Add("B");
            listB.Add("e");
            listB.Add("n");
            listA.Add("j");
            listA.Add("a");
            listA.Add("m");
            listA.Add("i");
            listA.Add("n");

            combinedList = listB + listA;



            actual = combinedList[5];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//19
        public void OverloadSubtractionOfLists_CheckCount_TwoListsOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            int expected = 2;
            int actual;

            //act
            listB.Add("B");
            listB.Add("e");
            listB.Add("n");
            listA.Add("B");
            listA.Add("a");
            listA.Add("m");
            listA.Add("i");
            listA.Add("p");

            combinedList = listB - listA;



            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//19
        public void OverloadSubtractionOfLists_CheckCount_TwoListsOfInts()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            ListB<int> listA = new ListB<int>();
            ListB<int> combinedList = new ListB<int>();
            int expected = 2;
            int actual;

            //act
            listB.Add(1);
            listB.Add(2);
            listB.Add(3);
            listA.Add(1);
            listA.Add(4);
            listA.Add(5);
            listA.Add(6);
            listA.Add(7);

            combinedList = listB - listA;



            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
