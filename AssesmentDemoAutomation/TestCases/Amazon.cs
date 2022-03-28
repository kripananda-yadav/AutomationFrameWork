using AssesmentDemoSite.Common;
using Common.Common;
using Commons.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentDemoAutomation.TestCases
{
    [TestFixture]
    public class Amazon:AmazonPageObject
    {
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void ReviewCount()
        {
            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            Nav.GoToUrl(Url);
            Locate.EnterText(SerachBoxXpath, "Samsung Galaxy S21", "Xpath");
            Locate.CLickOnWebElement(SearchButtonXpath, "Xpath");
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(ReviewButton, "Xpath");
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(MobileXpath, "Xpath");


            //var element = driver.FindElement(By.XPath(SeeAllReviewButtonXpath));
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath(SeeAllReviewButtonXpath)));
            actions.Click();
           // var Obj= BaseObj.ScrollTo(SeeAllReviewButtonXpath);

            Locate.CLickOnWebElement(SeeAllReviewButtonXpath,"Xpath");


        }

        [TearDown]
        public void close_Browser()
        {

            driver.Quit();
        }
    }
}
