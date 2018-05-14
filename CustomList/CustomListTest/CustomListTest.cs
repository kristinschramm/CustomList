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

            string expected = "string";

           // act call method
            customList.Add(input);
            string actual = customList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_CheckCount_CountIncreases() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string value = "string";
            int expectedCount = 1;

           // act call method
            customList.Add(value);
            int actualCount = customList.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);

        }

        [TestMethod]
        public void Add_CheckCapacity_CapacityIncreasesWhenLessThanCountMinus1() // should be descriptive of test
        {
           // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = value6;

           // act call method
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            int count = customList.Count;
            int actual = customList[5];


           // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckIndex_ValueIsAtEnd() // should be descriptive of test
        {
            //arange
            CustomListClass<string> customList = new CustomListClass<string>();
            string input = "words";
            string input2 = "other";
            string input3 = "something";
            string expected = input3;


            //act call method
            customList.Add(input);
            customList.Add(input2);
            customList.Add(input3);
            string actual = customList[2];


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
            int initialCount = 4;
            customList.Remove(customList[0]);
            int finalCount = customList.Count;

            //assert
            Assert.AreEqual(initialCount, finalCount);

        }
        [TestMethod]
        public void Remove_CheckWholeList_ValueRemoved()
        {
           // arrange
            CustomListClass<int> customList = new CustomListClass<int>();
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            bool expected = false;
            bool actual = false;

            //act
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value2);

            for (int i = 0; i > customList.Count; i++)
            {
                if (value2 == customList[i])
                {
                    actual = true;
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

           // act
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
        public void PlusOverload_CheckValueIndex0_Index0EqualsFirstArrayIndex0()

        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 6, 7, 8, 9, 10 };
            CustomListClass<int> newCustomList = new CustomListClass<int>();
            int expected = 1;

            //act

            newCustomList = customList1 + customList2;
            int actual = newCustomList[0];


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_CheckValueIndexI_IndexIEqualsSecondArrayIndex0()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 6, 7, 8, 9, 10 };
            CustomListClass<int> newCustomList = new CustomListClass<int>();
            int expected = 6;

            //act

            newCustomList=customList1 + customList2;
            int actual = newCustomList[5];


            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void PlusOverload_CheckCount_NewArrayCountEqualsTotalCountOfTwoArrays()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 6, 7, 8, 9, 10 };
            CustomListClass<int> newCustomList = new CustomListClass<int>();

            int expectedCount = 10;

            //act
            newCustomList= customList1 +customList2;
            int actualCount = newCustomList.Count;

            //assert

            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void PlusOverload_CheckCapacity_CheckCapacityIncreaseAfterAdd()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 6, 7, 8, 9, 10 };
            CustomListClass<int> newCustomList = new CustomListClass<int>();
            int expected = 0;


            //act
            newCustomList= customList1 + customList2;
            int actual = newCustomList[10];


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_CheckNewCount_CountDecreaseBySecondListCount()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 6, 7, 8, 9, 10 };
            
            int expectedCount = customList1.Count - customList2.Count;

            //act

            CustomListClass<int> customList3 = customList1 - customList2;
           
            int actualCount = customList3.Count;


            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void MinusOverload_CheckWholeList_ListRemoved()
        {
            //arrange
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 5, 6, 7, 8 };
           
            bool expected = false;
            bool actual = false;

            //act
            CustomListClass<int> customList3 = customList1 - customList2;


            for (int i = 0; i > customList2.Count; i++)
            {
                for (int j = 0; j > customList1.Count; j++)
                {
                    if (customList2[i] == customList1[j])
                    {
                        actual = true;
                        break;
                    }

                }
            }
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOverload_CheckValueAtIndexWhereListWasRemoved_ValueEqualsIndex()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 1, 3, 4, 5, 6 };
            CustomListClass<int> expectedList = new CustomListClass<int>() { 2, 7, 8, 9, 10 };

            //act
            CustomListClass<int> customList3 = customList1 - customList2;


            // assert

            Assert.AreEqual(expectedList[1], customList3[1]);
        }

        [TestMethod]
        public void MinusOverload_CheckNewListCount_ValueEqualsList1MinusList2()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 1, 3, 4, 5, 6 };
            int expectedCount = customList1.Count - customList2.Count;

            //act
            CustomListClass<int> customList3 = customList1 - customList2;
            int actualCount = customList3.Count;

            // assert

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Zipper_CheckValueAtSecondIndex_SecondIndexEqualsList2Index1()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 3, 5, 7, 9 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 2, 4, 6, 8, 10 };
            CustomListClass<int> customList3 = new CustomListClass<int>();


            //act
            customList3 = customList3.Zipper(customList1, customList2);

            // assert

            Assert.AreEqual(customList2[0], customList3[1]);
        }

        [TestMethod]
        public void Zipper_CheckCount_CountEqualsSumofListsCount()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 3, 5, 7, 9 };
            CustomListClass<int> customList2 = new CustomListClass<int>() { 2, 4, 6, 8, 10 };
            CustomListClass<int> customList3 = new CustomListClass<int>();
            int expectedCount = customList1.Count + customList2.Count;

            //act
            customList3 = customList3.Zipper(customList1, customList2);


            // assert

            Assert.AreEqual(expectedCount, customList3.Count);
        }

        //zipper test verify each index bool

        [TestMethod]
        public void ToString_CheckCount_CountEqualsSumofListsCount()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string stringList = "";
            string expectedString = "12345678910";

            //act
           stringList = customList1.ToString();


            // assert

            Assert.AreEqual(expectedString, stringList);
        }
        [TestMethod]
        public void ToString_DisplaySpace_StringDisplaysWithSpaces()
        {
            //act
            CustomListClass<int> customList1 = new CustomListClass<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string stringList = "";
            string expectedString = "1 2 3 4 5 6 7 8 9 10 ";

            //act
            stringList = customList1.ToString(" ");


            // assert

            Assert.AreEqual(expectedString, stringList);
        }

    }
}
