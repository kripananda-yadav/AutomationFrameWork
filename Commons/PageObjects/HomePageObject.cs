using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentDemoSite.PageObjects
{
    public class HomePageObject
    {

        #region LOCATORS
        public const string Url = "https://demoqa.com/";
        public const string FullNameXpath = "//div[@id='userName-wrapper']//input[@id='userName']";
        public const string EmailXpath = "//input[@id='userEmail']";
        public const string SubmitButtonXpath = "//button[@id='submit']";
        public const string HomeCheckBoxXpath = "//span[@class='rct-checkbox']";
        public const string YesRadioButtonXpath= "//input[@id='yesRadio']";
        
        public const string ClickMeButtonXpath = "//button[text()='Click Me']";
        public const string HomeLinkXpath = "";
        public const string AlterButtonXpath = "";
        public const string Frame = "";
        public const string SelectMenu = "";
        public const string AlertsFrameAndWindowsXpath = "//h5[text()='Alerts, Frame & Windows']";
        public const string AddButtonXpath = "//button[@title='Expand all']//*[name()='svg']";
        public const string NoteCheckBoxXpath = "//label[@for='tree-node-notes']//span[@class='rct-checkbox']//*[name()='svg']";
        public const string SuccessValueXpath = "//span[@class='text-success']";
        public const string NameOutputXpath = "//p[@id='name']";
        public const string EmailOutputXpath = "//p[@id='email']";
        public const string HomeHyperlinkXpath = "//a[@id='simpleLink' and text()='Home']";
        public const string linksButtonXpath = "//span[text()='Links']";
        //public const string HomeHyperlinkXpath = "//a[@id='simpleLink']";
       
        public const string BrokelinksButtonXpath = " //span[normalize-space()='Broken Links - Images']";



        #endregion

        #region SUBMENUSLOCATORS
        public const string ElementButtonXpath = "//div[contains(text(),'Elements')]";
        public const string TextBoxButtonXpath = "//span[contains(text(),'Text Box')]";
        public const string CheckBoxXpath = "//span[contains(text(),'Check Box')]";
        public const string RadioButtonXpath = "//span[contains(text(),'Radio Button')]";
        public const string ButtonXpath = "//span[contains(text(),'Buttons')]";


        #endregion
    }
}
