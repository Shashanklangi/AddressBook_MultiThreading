using NUnit.Framework;
using AddressBookMultiThreading;
using System.Collections.Generic;
using System;

namespace AddressBookTest
{
    public class Tests
    {
        List<AddressBook> AddressList;
        AddressBookOperations addressBookOperations;
        [SetUp]

        public void Setup()
        {
            AddressList = new List<AddressBook>();
            addressBookOperations = new AddressBookOperations();
        }

        [Test]
        public void CheckingTime_For_Inserting_Details()
        {
            AddressList.Add(new AddressBook(Firstname: "Charlie", Lastname: "Hades", Address: "SanDiego", City: "Miami", State: "Florida", Zip: 124563, PhoneNumber: 7854632598, Email: "hades@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Lucifer", Lastname: "Harward", Address: "Buckhimgam", City: "London", State: "NewYork", Zip: 147856, PhoneNumber: 7842365898, Email: "harwardlucifer@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Pablo", Lastname: "Escobar", Address: "BeverlyHills", City: "SanAndreas", State: "Washington", Zip: 136987, PhoneNumber: 7846932568, Email: "pablo@gmail.com"));

            DateTime StartDateTime = DateTime.Now;
            addressBookOperations.AddContacts(AddressList);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}