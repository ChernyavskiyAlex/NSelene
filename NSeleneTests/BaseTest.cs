﻿using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using static NSelene.Selene;


namespace NSeleneTests
{

    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void initDriver()
        {
            SetWebDriver(new FirefoxDriver());
        }

        [OneTimeTearDown]
        public void disposeDriver()
        {
            GetWebDriver().Quit();
        }
    }
}
