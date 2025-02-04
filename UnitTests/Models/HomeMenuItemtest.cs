﻿using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemtest
    {
        [Test]
        public void HomeMenuTest_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();
            // Reset

            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuTest_Set_Get_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();
            result.Id = MenuItemType.Items;
            result.Title = "Title";

            // Reset

            // Assert 
            Assert.AreEqual("Title", result.Title);
            Assert.AreEqual(MenuItemType.Items, result.Id);
        }
    }
}
