using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;



namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_CheckSpecificIndex_ValueExists() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string input = "string";
           
            string expected = customList[0];

            //act call method
            customList.Add(input);

            //assert
            Assert.AreEqual(expected, input);

        }
        [TestMethod]
        public void Add_CheckCount_CountIncreases() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string value = "string";
            int expectedCount = 1;

            //act call method
            customList.Add(value);
            int actualCount = customList.Count;

            //assert 
            Assert.AreEqual(expectedCount, actualCount);

        }

        [TestMethod]
        public void Add_CheckCapacity_CapacityIncreasesWhenLessThanCountMinus1() // should be descriptive of test
        {
            //arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value= 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;


            bool expectedBool = true;

            //act call method
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            int count = customList.Count;
            int capacity = customList.Capacity;
            bool actualBool = customList.CheckCapacity(count, capacity);//half capacity double length

            //assert 
            Assert.AreEqual(expectedBool, actualBool);
        }
        [TestMethod]
        public void Add_CheckIndex_ValueIsAtEnd() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string input = "words";
            string input2 = "other";
            string input3 = "something";
            string actual = "other";
            string expected = customList[1];


            //act call method
            customList.Add(input);
            customList.Add(input2);
            customList.Add(input3); 


            //assert assert. 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_CheckCount_CountDecreasesWhenIndexRemoved()
        {
            //arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;

            //act
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            int initialCount = customList.Count;
            customList.Remove(customList[0]);
            int finalCount = customList.Count;

            //assert
            Assert.AreEqual((initialCount - 1), finalCount);   

        }

        [TestMethod]
        public void Remove_CheckWholeList_ValueRemoved()
        {
            //arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            bool expected = false;
            bool actual = false ;

            //act
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value2);

            for(int i = 0; i > customList.Count; i++)
            {
                if (value2 == customList[i])
                {
                    actual=true;
                    break;
                }
                
            }
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_CheckIndex_NextIndexReplacesRemovedIndex()
        {
            //arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected;
            int actual;

            //act
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            expected = customList[2];       
            customList.Remove(value2);
            actual = customList[1];                      

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_()
        {

        }
    }


}
