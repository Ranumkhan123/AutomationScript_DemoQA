using DEMOQA_webautomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DEMOQA_webautomation
{
    [TestClass]
    public class TestCases : CorePage
    {

        #region Setups and Cleanups
        public TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        //Before every class
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {


        }


        //The TestInitialize attribute is needed when we want to run a function before executing a test.
        [TestInitialize]
        public void TestInit()
        {
            //The driver should always be called in the Test Initialize method
            CorePage.SeleniumInit();
        }

        //The TestCleanup will run after every test execution.
        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }
        #endregion


        ElementsScreens elementspage = new ElementsScreens();
        AlertsFrameandWindows alertframewindow = new AlertsFrameandWindows();
        WidgetsScreen widgets = new WidgetsScreen();

        [TestMethod]
        public void TextBoxinElementsTab()
        {
            elementspage.TextBox("https://demoqa.com/");
        }

        [TestMethod]
        public void CheckBoxinElementsTab()
        {
            elementspage.CheckBox("https://demoqa.com/");
        }

        [TestMethod]
        public void RadioButtoninElementsTab()
        {
            elementspage.RadioButton("https://demoqa.com/");
        }
        [TestMethod]
        public void WebTablesinElementsTab()
        {
            elementspage.WebTables("https://demoqa.com/");
        }

        [TestMethod]
        public void ButtonsinElementsTab()
        {
            elementspage.Buttons("https://demoqa.com/");
        }

        [TestMethod]
        public void LinksinElementsTab()
        {
            elementspage.Links("https://demoqa.com/");
        }

        [TestMethod]
        public void BrokenLinksinElementsTab()
        {
            elementspage.BrokenLinks("https://demoqa.com/");
        }

        [TestMethod]
        public void DynamicPropertiesinElementsTab()
        {
            elementspage.DynamicProperties("https://demoqa.com/");
        }


        [TestMethod]
        public void BrowserWindowTab()
        {
            alertframewindow.BrowserWindows("https://demoqa.com/");
        }

        [TestMethod]
        public void AlertsTab()
        {
            alertframewindow.Alerts("https://demoqa.com/");

        }

        [TestMethod]
        public void ModalDialogsTab()
        {
            alertframewindow.ModalDialogs("https://demoqa.com/");

        }

        [TestMethod]
        public void AccordianTab()
        {
            widgets.Accordian("https://demoqa.com/");

        }

        [TestMethod]
        public void ToolTipTab()
        {
            widgets.ToolTips("https://demoqa.com/");

        }


    }
}