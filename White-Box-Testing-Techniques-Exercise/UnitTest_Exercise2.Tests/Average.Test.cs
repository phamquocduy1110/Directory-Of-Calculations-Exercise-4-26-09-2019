using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Exercise2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Average average = new Average();
        int i;
        int minnum;
        int maxnum;
        int validNumber;
        int inputNumber;
        int sum = 0;
        float avg = 0;

        /// <summary>
        /// TC1: Test array_value wiht 2 elements { 100, -999 }, minnum = -50, maxnum = 100. The actualResult: <100>.
        /// </summary>
        [TestMethod]
        public void TestCase1()
        {
            //Arrange
            int[] array_value = new int[2] { 100, -999 };
            minnum = -50;
            maxnum = 100;

            float expectedResult = array_value[0];

            //Action
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC2: Test array wiht 1 elements { 15 }, minnum = 30, maxnum = 70. The actualResult: <-999>.
        /// </summary>
        [TestMethod]
        public void TestCase2()
        {
            //Arrange
            int[] array_value = new int[] { 15 };

            minnum = 30;
            maxnum = 70;


            float expectedResult = 0;

            //Action
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC3: Test array wiht 1 elements { -999 }, minnum = 10, maxnum = 20. The actualResult: <-999>.
        /// </summary>
        [TestMethod]
        public void TestCase3()
        {
            //Arrange
            int[] array = new int[] { -999 };

            minnum = 10;
            maxnum = 20;

            while ((array[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array[i] >= minnum) && (array[i] <= maxnum))
                {
                    validNumber++;
                    sum += array[i];
                }
                else break;
                i++;
            }

            if (validNumber > 0)
                avg = sum / validNumber;
            else
                avg = -999;

            float expectedResult = avg;

            //Action
            float actualResult = average.average(array, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC4: Test array wiht 3 elements { 8, 9, 20 }, minnum = 1, maxnum = 10. The actualResult: <8.5>.
        /// </summary>
        [TestMethod]
        public void TestCase4()
        {
            //Arrange
            int[] array_value = new int[] { 8, 9, 20 };

            minnum = 1;
            maxnum = 10;

            for (i = 0; i < 100; i++)
            {
                validNumber++;
                sum += array_value[i];
            }

            

            float expectedResult = sum / validNumber;

            //Action
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC5: Test array wiht 3 elements { 8, 9, 20 }, minnum = 1, maxnum = 10. The actualResult: <8.5>.
        /// </summary>
        [TestMethod]
        public void TestCase5()
        {
            //Arrange
            min
            int[] array_value = new int[100];

            array_value[0] = 1;
            array_value[1] = 2;
            array_value[2] = 3;
            array_value[3] = 4;
            array_value[4] = 5;
            array_value[5] = 6;
            array_value[6] = 7;
            array_value[7] = 8;
            array_value[8] = 9;

            array_value[9] = 10;

            
            float expectedResult = sum / validNumber;

            //Action
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC9: Test array wiht 3 elements { 120, 150, 180 }, minnum = 15, maxnum = 99. The actualResult: <-999>.
        /// </summary>
        [TestMethod]
        public void TestCase9()
        {
            //Arrange
            int[] array = new int[] { 120, 150, 180 };

            minnum = 15;
            maxnum = 99;

            while ((array[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array[i] >= minnum) && (array[i] <= maxnum))
                {
                    validNumber++;
                    sum += array[i];
                }
                else break;
                i++;
            }

            if (validNumber > 0)
                avg = sum / validNumber;
            else
                avg = -999;

            float expectedResult = avg;

            //Action
            float actualResult = average.average(array, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
