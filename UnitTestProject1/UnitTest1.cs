using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using CustomListProject2;


namespace UnitTestProject1
{
    [TestClass]
    public class CustomList
    {
        [TestMethod]
        public void Add_ToArray_IsActuallAdded()
        {
            //arrange
            CustomList2<int> firstlist = new CustomList2<int>();
            int val = 2;
            int expected = 1; //expected size of the array 
            int actual;  //actual size of array 

            //Act
            firstlist.Add(val);
            actual = firstlist.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_ToArray_ExpectedValueIsInArray()
        {
            //Arrange 
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 2;//expected value of index [0]
            int actual;

            //Act
            firstlist.Add(expected);
            actual = firstlist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ToArray_CountIsNotEqualToCapacity()
        {
            //arrange
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 4;//expected capacity of array
            int actual;

            //Act
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            actual = firstlist.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void add_ToArray_ArrayLengthIsNotEqualToExpectedLength()
        {
            //arrange
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 8;
            int actual = firstlist[7];

            //act
            firstlist.Add(1);
            firstlist.Add(0);
            firstlist.Add(0);
            firstlist.Add(0);
            firstlist.Add(1);
            firstlist.Add(1);
            firstlist.Add(9); // Array length is 7 not 8

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_toArray_SpecifiedIndexOfArrayNotExpected()
        {
            //arrange 
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 129873;

            //act
            firstlist.Add(104575);
            firstlist.Add(109828);
            firstlist.Add(129873);
            firstlist.Add(019828);

            int actual = firstlist[1];


            //Assert
            Assert.AreNotEqual(expected, actual);


        }
        [TestMethod]
        public void Remove_FromArray_ItemIsAvailableForRemoval()
        {
            //arrange
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 0;
            int actual = firstlist[3];
            int input = 3;

            //act
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            firstlist.Remove(1);
            
            
            
            ///firstlist = firstlist.Where(Val => Val != input).ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_FromArray_ItemIsNotAvailableForRemoval()
        {
            //arrange
            CustomList2<int> firstlist = new CustomList2<int>();
            int expected = 4;
            int actual = firstlist[3];

            //act
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            firstlist.Remove(2);

            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
