using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Common;
using AssesmentDemoSite.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AssesmentDemoSite.PageObjects;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;

namespace AssesmentDemoAutomation.TestCases
{

    
    [TestFixture]
    public class Home: HomePageObject
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
        public void ClickonMenu()
        {
         

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait= new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Locate.CLickOnWebElement(TextBoxButtonXpath, "Xpath");
            BaseObj.ScrollLittleDown();
            Locate.EnterText(FullNameXpath, "kripananda", "Xpath");
            Locate.EnterText(EmailXpath, "Kripananda@gmail.com", "Xpath");
            BaseObj.ScrollLittleDown();
            Locate.CLickOnWebElement(SubmitButtonXpath, "Xpath");

           
            try
            {
              
                var Output1 = driver.FindElement(By.XPath(NameOutputXpath));
                //Assert.IsTrue(driver.FindElement(By.XPath("//label[@for='tree-node-notes']//span[@class='rct-checkbox']//*[name()='svg']")).Selected);
                //Console.Write("CheckBox has been selected");
                Assert.AreEqual(Output1.Text, "Name:kripananda");
                var Output2 = driver.FindElement(By.XPath(EmailOutputXpath));              
                Assert.AreEqual(Output2.Text, "Email:Kripananda@gmail.com");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        [Test]
        public void checkBox()
        {

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            #region TESTCASE

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Locate.CLickOnWebElement(CheckBoxXpath, "Xpath");
            Locate.CLickOnWebElement(AddButtonXpath, "Xpath");
            Locate.CLickOnWebElement(NoteCheckBoxXpath, "Xpath");
            #region Assertion
            try
            {
                var Success = driver.FindElement(By.XPath(SuccessValueXpath));
                //Assert.IsTrue(driver.FindElement(By.XPath("//label[@for='tree-node-notes']//span[@class='rct-checkbox']//*[name()='svg']")).Selected);
                //Console.Write("CheckBox has been selected");
                Assert.AreEqual(Success.Text, "notes");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion

            #endregion
        }


        [Test]
        public void RadioButton()
        {

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            #region TESTCASE

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Locate.CLickOnWebElement(RadioButtonXpath, "Xpath");
            BaseObj.ScrollForRadioButton();
            Locate.CLickOnWebElement(YesRadioButtonXpath, "Xpath");
          
          
            #region Assertion
            try
            {
                var Success = driver.FindElement(By.XPath(SuccessValueXpath));
                //Assert.IsTrue(driver.FindElement(By.XPath("//label[@for='tree-node-notes']//span[@class='rct-checkbox']//*[name()='svg']")).Selected);
                //Console.Write("CheckBox has been selected");
                Assert.AreEqual(Success.Text, "Yes");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion

            #endregion
        }


        [Test]
        public void Button()
        {

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            #region TESTCASE

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); 
            BaseObj.ScrollLittleDown();
            Locate.CLickOnWebElement(ButtonXpath, "Xpath");
            Locate.CLickOnWebElement(ClickMeButtonXpath, "Xpath");
           
            #region Assertion
            try
            {
                
                Console.Write("ClickMe Button has been clicked");             

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion



            #endregion
        }

        [Test]
        public void Link()
        {

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            #region TESTCASE

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            BaseObj.ScrollLittleDown();
            Locate.CLickOnWebElement(linksButtonXpath, "Xpath");
            Locate.CLickOnWebElement(HomeHyperlinkXpath, "Xpath");
            BaseObj.SwitchTab();


            #region Assertion
            try
            {

            var Title=  driver.Title;
                Assert.AreEqual(Title, "ToolsQA");
                Console.Write(Title);             


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion



            #endregion
        }


        [Test]
        public void BrokenLink()
        {

            #region OBJECT CREATION
            Navigate Nav = new Navigate(driver);
            LocatorsAction Locate = new LocatorsAction(driver);
            BaseClass BaseObj = new BaseClass(driver);
            #endregion

            #region TESTCASE

            Nav.GoToUrl(Url);
            BaseObj.ScrollDown();
            Locate.CLickOnWebElement(AlertsFrameAndWindowsXpath, "Xpath");
            BaseObj.ScrollUp();
            Locate.CLickOnWebElement(ElementButtonXpath, "Xpath");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            BaseObj.ScrollLittleDown();
            Locate.CLickOnWebElement(BrokelinksButtonXpath, "Xpath");
            foreach(var item in driver.FindElements(By.TagName("a")))
            {
               var Link= item.GetAttribute("href");
            }
            
            Locate.CLickOnWebElement(HomeHyperlinkXpath, "Xpath");
            BaseObj.SwitchTab();


            #region Assertion
            try
            {

                var Title = driver.Title;
                Assert.AreEqual(Title, "ToolsQA");
                Console.Write(Title);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion



            #endregion
        }


        [TearDown]
        public void close_Browser()
        {

            driver.Quit();
        }


    }
}
