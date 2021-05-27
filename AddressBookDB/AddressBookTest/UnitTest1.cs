using AddressBookDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AddressBookRepo repo = new AddressBookRepo();
            AddressBookModel contact = new AddressBookModel();

            contact.FirstName = "Sham";
            contact.LastName = "Sundar";
            contact.Address = "02-Delhi";
            contact.City = "Delhi";
            contact.State = "Delhi";
            contact.Zip = "589612";
            contact.PhoneNumber = "8877559966";
            contact.Email = "sham@gmail.com";
            contact.Type = "Friend";
            var result = repo.AddEmployee(contact);
            Assert.IsTrue(result);
        }

    }
}
