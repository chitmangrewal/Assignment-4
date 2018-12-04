using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace assignment4
{

    [TestFixture]
    public class UntitledTestCase
    {
        [TestFixture]
        public class InvalidContact
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                baseURL = "https://www.katalon.com/";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {

                }
                Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
            public void ContactNumberTest()
            {
                driver.Navigate().GoToUrl("http://localhost/index.php");
                driver.FindElement(By.Id("Name")).Click();
                driver.FindElement(By.Id("Name")).Clear();
                driver.FindElement(By.Id("Name")).SendKeys("chitman");
                driver.FindElement(By.Id("Address")).Clear();
                driver.FindElement(By.Id("Address")).SendKeys("doon");
                driver.FindElement(By.Id("City")).Clear();
                driver.FindElement(By.Id("City")).SendKeys("kitchener");
                driver.FindElement(By.Id("Phone")).Clear();
                driver.FindElement(By.Id("Phone")).SendKeys("4568");
                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("cgrewal@gmail.com");
                driver.FindElement(By.Id("Make")).Clear();
                driver.FindElement(By.Id("Make")).SendKeys("Ford");
                driver.FindElement(By.Id("Model")).Clear();
                driver.FindElement(By.Id("Model")).SendKeys("Mustang");
                driver.FindElement(By.Id("Year")).Clear();
                driver.FindElement(By.Id("Year")).SendKeys("2011");
                driver.FindElement(By.Id("btn")).Click();
                Assert.AreEqual("Enter valid Phone Number", CloseAlertAndGetItsText());
            }
            [Test]
            public void FormIncompleteTest()
            {
                driver.Navigate().GoToUrl("http://localhost/index.php");
                driver.FindElement(By.Id("Name")).Click();
                driver.FindElement(By.Id("Name")).Clear();
                driver.FindElement(By.Id("Name")).SendKeys("chitmn");
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Address")).Clear();
                driver.FindElement(By.Id("Address")).SendKeys("cgrewal@gmail.com");
                driver.FindElement(By.Id("Phone")).Click();
                driver.FindElement(By.Id("Phone")).Clear();
                driver.FindElement(By.Id("Phone")).SendKeys("24567897866");
                driver.FindElement(By.Id("Email")).Click();
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Address")).Clear();
                driver.FindElement(By.Id("Address")).SendKeys("doon");
                driver.FindElement(By.Id("City")).Click();
                driver.FindElement(By.Id("City")).Clear();
                driver.FindElement(By.Id("City")).SendKeys("kitchener");
                driver.FindElement(By.Id("Email")).Click();
                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("a@gmail.com");
                driver.FindElement(By.Id("Make")).Click();
                driver.FindElement(By.Id("Make")).Clear();
                driver.FindElement(By.Id("Make")).SendKeys("ford");
                driver.FindElement(By.Id("Model")).Click();
                driver.FindElement(By.Id("Model")).Clear();
                driver.FindElement(By.Id("Model")).SendKeys("mustang");
                driver.FindElement(By.Id("Year")).Click();
                driver.FindElement(By.Id("Year")).Clear();
                driver.FindElement(By.Id("Year")).SendKeys("2013");
                driver.FindElement(By.Id("City")).Click();
                driver.FindElement(By.Id("City")).Clear();
                driver.FindElement(By.Id("City")).SendKeys("");
                driver.FindElement(By.Name("submit")).Click();
                Assert.AreEqual("Enter valid City", CloseAlertAndGetItsText());
            }
            [Test]
            public void ValidateSellerName_Test()
            {
                driver.Navigate().GoToUrl("http://localhost/index.php");
                driver.FindElement(By.Id("btn")).Click();
                Assert.AreEqual("Enter valid Seller name", CloseAlertAndGetItsText());
            }
            [Test]
            public void ValidateLink_Test()
            {
                driver.Navigate().GoToUrl("http://localhost/index.php");
                driver.FindElement(By.Id("Name")).Click();
                driver.FindElement(By.Id("Name")).Clear();
                driver.FindElement(By.Id("Name")).SendKeys("chitmn");
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Address")).Clear();
                driver.FindElement(By.Id("Address")).SendKeys("cgrewal@gmail.com");
                driver.FindElement(By.Id("City")).Click();
                driver.FindElement(By.Id("City")).Clear();
                driver.FindElement(By.Id("City")).SendKeys("doon");
                driver.FindElement(By.Id("Phone")).Click();
                driver.FindElement(By.Id("Phone")).Clear();
                driver.FindElement(By.Id("Phone")).SendKeys("1234567890");
                driver.FindElement(By.Id("Make")).Click();
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Email")).Click();
                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("cgrewal@gmail.com");
                driver.FindElement(By.Id("Address")).Click();
                driver.FindElement(By.Id("Address")).Clear();
                driver.FindElement(By.Id("Address")).SendKeys("12 south doon");
                driver.FindElement(By.Id("Make")).Click();
                driver.FindElement(By.Id("Make")).Clear();
                driver.FindElement(By.Id("Make")).SendKeys("ford");
                driver.FindElement(By.Id("Year")).Click();
                driver.FindElement(By.Id("Year")).Clear();
                driver.FindElement(By.Id("Year")).SendKeys("2013");
                driver.FindElement(By.Id("Model")).Click();
                driver.FindElement(By.Id("Model")).Clear();
                driver.FindElement(By.Id("Model")).SendKeys("mustang");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search'])[1]/following::input[10]")).Click();
                driver.FindElement(By.Id("link")).Click();
            }


            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }
}

