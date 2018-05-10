using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;



namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Custom_List_Add_CheckifValueExistsAtIndex() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string input = "string";
            string actual = "string";
            string expected = customList[0];

            //act call method
            customList.Add(input);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Custom_List_Add_CheckCount() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string value = "string";
            int expectedCount = 1;

            //act call method
            customList.Add(value);
            int actualCount = customList.Count();

            //assert 
            Assert.AreEqual(expectedCount, actualCount);

        }

        [TestMethod]
        public void Custom_List_Add_CheckExistingArrayLength() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string value= "string";
            bool expectedBool = true;

            //act call method
            customList.Add(value);
            int count = customList.Count();
            int capacity = customList.Capacity()
            bool actualBool = CheckCapacity(count, capacity);

            //assert 
            Assert.AreEqual(expectedBool, actualBool);
        }
        [TestMethod]
        public void Custom_List_Add_CheckListValues() // should be descriptive of test
        {
            //arrange
            CustomListClass<string> customList = new CustomListClass<string>();
            string input = "words";
            string input2 = "other";
            string input3 = "something";
            CustomListClass<string> expected = {"words", "other", "something"};


            //act call method
            customList.Add(input);
            customList.Add(input2);
            customList.Add(input3);
            CustomListClass<string> actual = customList; 

            //assert assert. 
            Assert.AreEqual(expected, actual);

        }
    }
}
