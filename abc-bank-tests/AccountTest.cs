﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using abc_bank.Accounts;

namespace abc_bank_tests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CreateCheckingAccount()
        {
            Account account = Account.Create(Account.AccountType.Checking);
            Assert.IsTrue(account is CheckingAccount);
        }
        [TestMethod]
        public void CreateSavingsAccount()
        {
            Account account = Account.Create(Account.AccountType.Savings);
            Assert.IsTrue(account is SavingsAccount);
        }
        [TestMethod]
        public void CreateMaxiSavingsAccount()
        {
            Account account = Account.Create(Account.AccountType.MaxiSavings);
            Assert.IsTrue(account is MaxiSavingsAccount);
        }
        [TestMethod]
        public void CreateUnknownAccount()
        {

            //Account account = Account.Create();
            //Assert.IsNotInstanceOfType(account, typeof(Account));
        }
    }
}