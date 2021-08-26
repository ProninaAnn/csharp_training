using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData ("admin", "secret"));
            InitContactCreation();
            ContactData contact = new ContactData("Аня");
            contact.Firstname = "Аня";
            contact.Middlename = "Pushin";
            contact.Nickname = "Pronya";
            contact.Title = "Заголовок";
            contact.Company = "google";
            contact.Address = "г. Москва";
            contact.Mobile = "88002000600";
            contact.Email = "mail@mail.ru";
            contact.Address2 = "г.Севастополь";
            contact.Phone2 = "89003000600";
            contact.Notes = "Заметка";
            FillContactForm(contact);
            InputContact();
            ReturnHomePage();
            Logout();
        }
    }
}
