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

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC5: Test array wiht 100 elements { 1,...,99 }, minnum = 1, maxnum = 50. The actualResult: <25.5>.
        /// </summary>
        [TestMethod]
        public void TestCase5()
        {
            //Arrange
            int[] array_value = new int[99];

            for (var i = 1; i < array_value.Length; i++)
            {
                array_value[i] = i;
            }

            minnum = 1;
            maxnum = 50;

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC6: Test array wiht 100 elements { 1,...,99 }, minnum = 1, maxnum = 99. The actualResult: <50>.
        /// </summary>
        [TestMethod]
        public void TestCase6()
        {
            //Arrange
            int[] array_value = new int[99];

            for (var i = 1; i < array_value.Length; i++)
            {
                array_value[i] = i;
            }

            minnum = 1;
            maxnum = 50;

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC7: Test array wiht 100 elements { 1,...,100 }, minnum = 1, maxnum = 100. The actualResult: <50>.
        /// </summary>
        [TestMethod]
        public void TestCase7()
        {
            //Arrange
            int[] array_value = new int[100];

            for (var i = 1; i < array_value.Length; i++)
            {
                array_value[i] = i;
            }

            minnum = 1;
            maxnum = 100;

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC8: Test array wiht 100 elements { 1,...,101 }, minnum = 1, maxnum = 101. The actualResult: <50>.
        /// </summary>
        [TestMethod]
        public void TestCase8()
        {
            //Arrange
            int[] array_value = new int[100];

            for (var i = 1; i < array_value.Length; i++)
            {
                array_value[i] = i;
            }

            minnum = 1;
            maxnum = 101;

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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

        // <summary>
        ///  TC10: Test array null, minnum = 30, maxnum = 70. The actualResult: <Error>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCase10()
        {
            //Arrange
            int[] array_value = null;

            minnum = 30;
            maxnum = 70;

            while ((array_value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                {
                    validNumber++;
                    sum += array_value[i];
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
            float actualResult = average.average(array_value, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC11: Test array with 6 elements { 10, 30, 40, 70, 99, 50 }, minnum = null, maxnum = 99. The actualResult: <Error>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestCase11()
        {
            //Arrange
            int[] array = new int[] { 10, 30, 40, 70, 99, 50 };

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

        /// <summary>
        ///  TC12: Test array with 3 elements { 20, 50, 68 }, minnum = 30, maxnum = null. The actualResult: <Error>.
        /// </summary>
        [TestMethod]
        ///[ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestCase12()
        {
            //Arrange
            int[] array = new int[] { 20, 50, 68 };

            minnum = 30;

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

            float expectedResult = "Error message";

            //Action
            float actualResult = average.average(array, minnum, maxnum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        ///  TC13: Test array with 100 elements { 10, 45, 50, 68, 90, 99 }, minnum = 40.1, maxnum = 70. The actualResult: <error>.
        /// </summary>
        [TestMethod]
        public void TesCase13()
        {
            //Arrange
            int[] array_value = new int[100];

            for (var i = 1; i < array_value.Length; i++)
            {
                array_value[i] = i;
            }

            double minnum = 40.1;
            double maxnum = 70;

            if (array_value.Length > 0 && minnum != 0 && maxnum != 0)
            {
                if (minnum * 10 == (int)minnum * 10)
                {
                    while ((array_value[i] != -999) && (inputNumber < 100))
                    {
                        inputNumber++;
                        if ((array_value[i] >= minnum) && (array_value[i] <= maxnum))
                        {
                            validNumber++;
                            sum += array_value[i];
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
                    float actualResult = average.average(array_value, minnum, maxnum);

                    //Assert
                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
            string expectedResult1 = "Error message";
            Assert.AreEqual(expectedResult1, "Error message");
        }
    }
}
