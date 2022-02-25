using System;
using _10553527_B8IT150_CA1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;


namespace GUI.UnitTest
{
    [TestClass]
    public class MethodTests
    {
        // IsValidIBSN() Tests

        [TestMethod]
        public void ValidIBSN_IsNull_ReturnsFalse()
        {
            var result = CreateBookForm.IsValidIBSN("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidIBSN_IsNotDigits_ReturnsFalse()
        {
            var result = CreateBookForm.IsValidIBSN("Not Digits!");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidIBSN_IsNot10igits_ReturnsFalse()
        {
            var result = CreateBookForm.IsValidIBSN("12345");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidIBSN_Is10Digits_ReturnsTrue()
        {
            var result = CreateBookForm.IsValidIBSN("1234567890");
            Assert.IsTrue(result);
        }

        // IsValidYear() Tests

        [TestMethod]
        public void ValidYear_IsNull_ReturnsFalse()
        {
            var result = CreateBookForm.IsValidYear("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidYear_IsNotDigits_ReturnsFalse()
        {
            CreateBookForm newForm = new CreateBookForm();
            var result = CreateBookForm.IsValidYear("Not Digits!");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidYear_IsNot4Digits_ReturnsFalse()
        {
            CreateBookForm newForm = new CreateBookForm();
            var result = CreateBookForm.IsValidYear("1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidYear_Is4Digits_ReturnsTrue()
        {
            CreateBookForm newForm = new CreateBookForm();
            var result = CreateBookForm.IsValidYear("2000");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidYear_IsNotGreaterThanCurrentYear_ReturnsTrue()
        {
            var result = CreateBookForm.IsValidYear("2000");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidYear_IsGreaterThanCurrentYear_ReturnsTrue()
        {
            var result = CreateBookForm.IsValidYear($"{ DateTime.Now.Year + 1} ");
            Assert.IsFalse(result);
        }
    }
}
