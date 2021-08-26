﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData ("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("new name");
            group.Header = "new header";
            group.Footer = "new footer";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }
    }
}
