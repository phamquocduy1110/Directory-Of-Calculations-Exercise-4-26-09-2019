using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Examples.Tests
{
    [TestClass]
    public class TriangleTest
    {
        Triangle myTriangle = new Triangle();
        string[] arr_trianglesides = new string[3];
        /// <summary>
        /// TC1: Kiểm tra nếu cạnh 1, cạnh 2 và cạnh 3 bằng nhau thì kết quả trả về là tam giác đều
        /// </summary>
        [TestMethod]
        public void CheckTriangle_With3SidesAreEqual_ShouldBeEquilateral()
        {
            //Arrange
            arr_trianglesides[0] = "68";
            arr_trianglesides[1] = "68";
            arr_trianglesides[2] = "68";
            string expectedResult = "It's an Equilateral Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        /// <summary>
        /// TC2: Kiểm tra nếu cạnh 1 và cạnh 2 bằng nhau thì kết quả trả về là tam giác cân
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1EqualSide2_ShouldBeIsosceles()
        {
            //Arrange
            arr_trianglesides[0] = "68";
            arr_trianglesides[1] = "68";
            arr_trianglesides[2] = "56";
            string expectedResult = "It's an Isosceles Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC3: Kiểm tra nếu cạnh 2 và cạnh 3 bằng nhau thì kết quả trả về là tam giác cân
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2EqualSide3_ShouldBeIsosceles()
        {
            //Arrange
            arr_trianglesides[0] = "25";
            arr_trianglesides[1] = "30";
            arr_trianglesides[2] = "30";
            string expectedResult = "It's an Isosceles Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC4: Kiểm tra nếu cạnh 1 và cạnh 3 bằng nhau thì kết quả trả về là tam giác cân
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1EqualSide3_ShouldBeIsosceles()
        {
            //Arrange
            arr_trianglesides[0] = "25";
            arr_trianglesides[1] = "30";
            arr_trianglesides[2] = "25";
            string expectedResult = "It's an Isosceles Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC5: Kiểm tra nếu 3 cạnh không bằng nhau thì kết quả trả về là tam giác thường
        /// </summary>
        [TestMethod]
        public void CheckTriangle_With3SidesAreNotEqual_ShouldBeScalene()
        {
            //Arrange
            arr_trianglesides[0] = "68";
            arr_trianglesides[1] = "60";
            arr_trianglesides[2] = "56";
            string expectedResult = "It's a Scalene Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC6: Kiểm tra nếu độ dài cạnh 1 lớn hơn tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1GreaterThanSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "68";
            arr_trianglesides[1] = "1";
            arr_trianglesides[2] = "56";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC7: Kiểm tra nếu độ dài cạnh 2 lớn hơn tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2GreaterThanSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "8";
            arr_trianglesides[1] = "25";
            arr_trianglesides[2] = "15";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC8: Kiểm tra nếu độ dài cạnh 3 lớn hơn tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide3GreaterThanSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "8";
            arr_trianglesides[1] = "12";
            arr_trianglesides[2] = "25";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC9: Kiểm tra nếu độ dài cạnh 1 bằng tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1GEqualSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "30";
            arr_trianglesides[1] = "12";
            arr_trianglesides[2] = "18";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC10: Kiểm tra nếu độ dài cạnh 2 bằng tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2GEqualSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "18";
            arr_trianglesides[1] = "30";
            arr_trianglesides[2] = "12";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC11: Kiểm tra nếu độ dài cạnh 3 bằng tổng độ dài hai cạnh còn lại thì kết quả trả về không phải là tam giác
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide3GEqualSumOf2RemainedSides_ShouldBeNotTriangle()
        {
            //Arrange
            arr_trianglesides[0] = "18";
            arr_trianglesides[1] = "12";
            arr_trianglesides[2] = "30";
            string expectedResult = "It's not a Triangle";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T12: Kiểm tra nếu độ dài cạnh 1 bằng 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1EqualZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "0";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "8";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T13: Kiểm tra nếu độ dài cạnh 2 bằng 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2EqualZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "4";
            arr_trianglesides[1] = "0";
            arr_trianglesides[2] = "7";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T14: Kiểm tra nếu độ dài cạnh 3 bằng 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide3EqualZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "8";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "0";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T15: Kiểm tra nếu độ dài cạnh 1 nhỏ hơn 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1LessThanZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "-1";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "4";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T16: Kiểm tra nếu độ dài cạnh 2 nhỏ hơn 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2LessThanZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "6";
            arr_trianglesides[1] = "-2";
            arr_trianglesides[2] = "7";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T17: Kiểm tra nếu độ dài cạnh 3 nhỏ hơn 0 thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide3LessThanZero_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "7";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "-1";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T18: Kiểm tra nếu độ dài cạnh 1 không phải là số nguyên thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide1NotInteger_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "2.5";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "15";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T19: Kiểm tra nếu độ dài cạnh 2 không phải là số nguyên thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide2NotInteger_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "5";
            arr_trianglesides[1] = "7.5";
            arr_trianglesides[2] = "5";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// T18: Kiểm tra nếu độ dài cạnh 3 không phải là số nguyên thì kết quả trả về lỗi nhập liệu
        /// </summary>
        [TestMethod]
        public void CheckTriangle_WithSide3NotInteger_ShouldBeInputError()
        {
            //Arrange
            arr_trianglesides[0] = "10";
            arr_trianglesides[1] = "5";
            arr_trianglesides[2] = "4.5";
            string expectedResult = "The length of triangle side must be an integer and greater than zero";

            //Action
            string actualResult = myTriangle.CheckTriangle(arr_trianglesides);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
