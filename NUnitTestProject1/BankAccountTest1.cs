using NUnit.Framework;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitTestProject1
{
    [TestClass]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}