using DEMOQA_webautomation.AlertsFrameandWindowsPages;
using DEMOQA_webautomation.Pages;
using DEMOQA_webautomation.WidgetsPages;
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


        TextBox textbox = new TextBox();
        CheckBox checkbox = new CheckBox();
        RadioButton radioButton = new RadioButton();
        WebTables webtables = new WebTables();
        Buttons buttons = new Buttons();
        Links links = new Links();
        BrokenLinks brokenlinks = new BrokenLinks();
        DynamicProperties dynamicproperties = new DynamicProperties();

        Alerts alerts = new Alerts();
        BrowserWindows browserwindows = new BrowserWindows();
        ModalDialogs modal = new ModalDialogs();

        Accordian accordian= new Accordian();
        Menu menu = new Menu();
        ProgressBar progressbar = new ProgressBar();
        SelectMenu selectmenu = new SelectMenu();
        Tabs tabs = new Tabs();
        ToolTips tooltips = new ToolTips();

        
       

       

        [TestMethod]
        public void TextBoxinElements()
        {
            
            textbox.TextBoxTab("https://demoqa.com/");
        }

        [TestMethod]
        public void CheckBoxinElements()
        {
           
            checkbox.CheckBoxTab("https://demoqa.com/");
        }

        [TestMethod]
        public void RadioButtoninElements()
        {
            radioButton.RadioButtonTab("https://demoqa.com/");
        }
        [TestMethod]
        public void WebTablesinElements()
        {
            webtables.WebTablesTab("https://demoqa.com/");
        }

        [TestMethod]
        public void ButtonsinElements()
        {
           buttons.ButtonsTab("https://demoqa.com/");
        }

        [TestMethod]
        public void LinksinElements()
        {
            links.LinksTab("https://demoqa.com/");
        }

        [TestMethod]
        public void BrokenLinksinElements()
        {
           brokenlinks.BrokenLinksTab("https://demoqa.com/");
        }

        [TestMethod]
        public void DynamicPropertiesinElements()
        {
            dynamicproperties.DynamicPropertiesTab("https://demoqa.com/");
        }


        [TestMethod]
        public void BrowserWindowTabInAlertNFrame()
        {
            browserwindows.BrowserWindowsTab("https://demoqa.com/");
        }

        [TestMethod]
        public void AlertsTabInAlertNFrame()
        {
            alerts.AlertsTab("https://demoqa.com/");

        }

        [TestMethod]
        public void ModalDialogsTabInAlertNFrame()
        {
            modal.ModalDialogsTab("https://demoqa.com/");

        }

        [TestMethod]
        public void AccordianTab()
        {
           accordian.AccordianTab("https://demoqa.com/");

        }

        [TestMethod]
        public void ToolTipTab()
        {
            tooltips.ToolTipsTab("https://demoqa.com/");

        }

        [TestMethod]
        public void MenuTab()
        {
            menu.MenusTab("https://demoqa.com/");

        }

        [TestMethod]
        public void SelectMenuTab()
        {
           selectmenu.SelectMenuTab("https://demoqa.com/");

        }

        [TestMethod]
        public void TabsTab()
        {
           tabs.TabsTab("https://demoqa.com/");

        }


        [TestMethod]
        public void ProgressBarTab()
        {
           progressbar.ProgressBarTab("https://demoqa.com/");

        }

    }
}