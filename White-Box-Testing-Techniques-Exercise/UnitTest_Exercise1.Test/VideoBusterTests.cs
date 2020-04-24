using System;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Exercise1.Test
{
    [TestClass]
    public class VideoBusterTests
    {
        VideoBuster myVideoBuster = new VideoBuster();
        Tape[] tapes;
        Customer customer = new Customer();
        double total;

        /// <summary>
        /// TC1: Kiểm tra khách hàng được giảm 30% trong trường hợp thuê trên 10 sản phẩm và được giảm thêm 10% khi khách
        /// hàng là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLengthGreaterThan10AndPremium_ShouldDiscount30Percent()
        {
            // Arrange
            tapes = new Tape[11]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10},
                new Tape { price = 5},
                new Tape { price = 20},
                new Tape { price = 25},
                new Tape { price = 15},
                new Tape { price = 30},
                new Tape { price = 15},
                new Tape { price = 5}
            };
            customer.isPremium = true;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.8 * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC2: Kiểm tra khách trường hợp thuê 3 sản phẩm và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength3AndPremium()
        {
            // Arrange
            tapes = new Tape[3]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
            };
            customer.isPremium = true;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC3: Kiểm tra khách hàng được giảm 10% trong trường hợp thuê trên 5 sản phẩm và được giảm thêm 10%
        /// khi khách hàng là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLengthGreaterThan5AndnotPremium_ShouldDiscount10Percent()
        {
            // Arrange
            tapes = new Tape[6]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10},
                new Tape { price = 5},
                new Tape { price = 20}
            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC4: Kiểm tra khách hàng trường hợp thuê trên 4 sản phẩm và được giảm thêm 10% khi khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength4AndnotPremium()
        {
            // Arrange
            tapes = new Tape[4]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10}
            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC5: Kiểm tra khách hàng trường hợp không sản phẩm và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength0AndnotPremium()
        {
            // Arrange
            tapes = new Tape[1]
            {
                new Tape { price = 0}
            };
            customer.isPremium = false;

            double total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.8 * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC6: Kiểm tra khách hàng trường hợp thuê 1 sản phẩm và khách hàng là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength1AndPremium()
        {
            // Arrange
            tapes = new Tape[1]
            {
                new Tape { price = 10}
            };
            customer.isPremium = true;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // <summary>
        /// TC7: Kiểm tra khách hàng trường hợp thuê 2 sản phẩm và khách hàng là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength2AndPremium()
        {
            // Arrange
            tapes = new Tape[2]
            {
                new Tape { price = 10},
                new Tape { price = 15}
            };
            customer.isPremium = true;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC8: Kiểm tra khách hàng được giảm 10% trường hợp thuê trên 5 sản phẩm và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLengthGreaterThan5AndnotPremium_ShouldBe10Percent()
        {
            // Arrange
            tapes = new Tape[10]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10},
                new Tape { price = 5},
                new Tape { price = 20},
                new Tape { price = 15},
                new Tape { price = 25},
                new Tape { price = 30},
                new Tape { price = 15}
            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC9: Kiểm tra khách hàng được giảm 10% trường hợp thuê trên 5 sản phẩm và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength9AndnotPremium_ShouldBe10Percent()
        {
            // Arrange
            tapes = new Tape[9]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10},
                new Tape { price = 5},
                new Tape { price = 20},
                new Tape { price = 15},
                new Tape { price = 25},
                new Tape { price = 30}
            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 0.9;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC10: Kiểm tra khách hàng trường hợp thuê 5 sản phẩm và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLength5AndnotPremium()
        {
            // Arrange
            tapes = new Tape[5]
            {
                new Tape { price = 10},
                new Tape { price = 15},
                new Tape { price = 5},
                new Tape { price = 10},
                new Tape { price = 5}
            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TC11: Kiểm tra khách hàng trường hợp thuê sản phẩm là rỗng và khách hàng không là Premium
        /// </summary>
        [TestMethod]
        public void calcRentalFee_WithTapesLengthNullAndnotPremium()
        {
            // Arrange
            tapes = new Tape[0]
            {

            };
            customer.isPremium = false;

            total = 0;
            for (int i = 0; i < tapes.Length; i++)
            {
                total += tapes[i].price;
            }
            double expectedResult = total * 1;

            // Action
            double actualResult = myVideoBuster.calcRentalFee(tapes, customer);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
