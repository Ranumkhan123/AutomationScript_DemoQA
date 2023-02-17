using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Threading;
using static System.Collections.Specialized.BitVector32;

namespace DEMOQA_webautomation.Pages
{
    public class WidgetsScreen : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
        By accordiantab = By.XPath("//span[normalize-space()='Accordian']");
        By section1Heading = By.XPath("//div[@id='section1Heading']");
        By section1Text = By.XPath("//p[contains(text(),'Lorem Ipsum is simply dummy text of the printing a')]");
        By section2Heading = By.XPath("//div[@id='section2Heading']");
        By section2Text = By.XPath("//p[contains(text(),'Contrary to popular belief, Lorem Ipsum is not sim')]");
        By section3Heading = By.XPath("//div[@id='section3Heading']");
        By section3Text = By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]");
        By tooltiptab = By.XPath("//span[normalize-space()='Tool Tips']");
        By tooltipheading = By.XPath("//p[normalize-space()='Practice Tool Tips']");
        By hoverButton = By.XPath("//button[@id='toolTipButton']");
        By hoveredtxt = By.XPath("//div[contains(text(),'You hovered over the Button')]");
        By menuTab = By.XPath("//span[normalize-space()='Menu']");
        By mainitem1 = By.XPath("//a[normalize-space()='Main Item 1']");
        By mainitem2 = By.XPath("//a[normalize-space()='Main Item 2']");
        By subitem = By.XPath("(//a[@href='#'][normalize-space()='Sub Item'])[1]");
        By subitemlist = By.XPath("//a[normalize-space()='SUB SUB LIST »']");
        By subsubitem = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/ul/li[1]/a");
        By selectmenuTab = By.XPath("//span[normalize-space()='Select Menu']");
        By selectvalue = By.XPath("//div[contains(text(),'Select Value')]");
        By selectvaluedropdown = By.XPath("//div[contains(text(),'Select Option')]");
        By selectoptions = By.XPath("//div[contains(text(),'Another root option')]");
        By selectone = By.XPath("//div[@id='selectOne']//div//div//div[@aria-hidden='true']");
        By selectonevalue = By.XPath("//div[contains(text(),'Ms.')]");
        By oldSelectMenu = By.XPath("//select[@id='oldSelectMenu']");
        By selectoldSelectMenuValue = By.XPath("//*[@id=\"oldSelectMenu\"]/option[2]");
        By multiselectdropdown = By.XPath("//body/div[@id='app']/div/div/div/div/div[@id='selectMenuContainer']/div[7]/div[1]/div[1]/div[1]/div[2]/div[1]");
        By multiselectvalue = By.XPath("//div[contains(text(),'Green')]");
        By Tabstab = By.XPath("//span[normalize-space()='Tabs']");
        By tabsheading = By.XPath("//div[normalize-space()='Details about Lorem Ipsum']");
        By whattab = By.XPath("//a[@id='demo-tab-what']");
        By what = By.XPath("//p[contains(text(),'Lorem Ipsum is simply dummy text of the printing a')]");
        By origin = By.XPath("//a[@id='demo-tab-origin']");
        By origintxt = By.XPath("//p[contains(text(),'Contrary to popular belief, Lorem Ipsum is not sim')]");
        By use = By.XPath("//a[@id='demo-tab-use']");
        By usetxt = By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]");
        By progressbartab = By.XPath("//span[normalize-space()='Progress Bar']");
        By startStopButton = By.XPath("//button[@id='startStopButton']");
        By progressbar = By.XPath("//div[@id='progressBar']");
        By resetButton = By.XPath("//button[@id='resetButton']");
        By sliderTab = By.XPath("//span[normalize-space()='Slider']");
        By rangebtn = By.XPath("//input[@type='range']");


        public void Accordian(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            //Action Actions = new Action(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);
            Console.WriteLine();

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //click Accordian TAB from the side menu
            string textofbtn = driver.FindElement(accordiantab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();
            driver.FindElement(accordiantab).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(section1Heading));

            //SECTION 1 
            string section1heading = driver.FindElement(section1Heading).Text;
            Console.WriteLine("Section One: " + section1heading);

            string section1text = driver.FindElement(section1Text).Text;
            Console.WriteLine(section1text);
            Console.WriteLine();

            driver.FindElement(section1Heading).Click();


            //SECTION 2
            driver.FindElement(section2Heading).Click();

            string section2heading = driver.FindElement(section2Heading).Text;
            Console.WriteLine("Section Two: " + section2heading);

            string section2text = driver.FindElement(section2Text).Text;
            Console.WriteLine(section2text);
            Console.WriteLine();



            //SECTION 3
            scroll.ExecuteScript("window.scrollTo(0, 400)");
            driver.FindElement(section3Heading).Click();

            string section3heading = driver.FindElement(section3Heading).Text;
            Console.WriteLine("Section Three: " + section3heading);

            string section3text = driver.FindElement(section3Text).Text;
            Console.WriteLine(section3text);
            Console.WriteLine();
        }

        public void ToolTips(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);
            Console.WriteLine();

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,450)");

            //click TOOLTIP TAB from the side menu
            string textofbtn = driver.FindElement(tooltiptab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(tooltiptab).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tooltipheading));
            //TOOL TIP SCREEN
            string tooltipscreenheading = driver.FindElement(tooltipheading).Text;
            Console.WriteLine("Tool Tip Screen: " + tooltipscreenheading);
            Console.WriteLine();

            //HOVER OVER BUTTON

            string hoveroverbtn = driver.FindElement(hoverButton).Text;
            Console.WriteLine("Hover Over Button: " + hoveroverbtn);

            actions.MoveToElement(driver.FindElement(hoverButton)).Perform();

            string textinthehover = driver.FindElement(hoveredtxt).Text;
            Console.WriteLine("Hovered: " + textinthehover);

            Thread.Sleep(1000);

        }

        public void Menu(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,500)");

            //click MENU TAB from the side menu
            string textofbtn = driver.FindElement(menuTab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(menuTab).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(mainitem1));

            //Main Menu 2
            string menu2 = driver.FindElement(mainitem2).Text;
            Console.WriteLine("Menu: " + menu2);

            actions.MoveToElement(driver.FindElement(mainitem2)).Perform();

            Thread.Sleep(1000);



            //SUB Menu

            string submenu = driver.FindElement(subitem).Text;
            Console.WriteLine("Menu: " + submenu);

            wait.Until(ExpectedConditions.ElementToBeClickable(subitemlist));


            //SUB ITEM LIST

            string submenulist = driver.FindElement(subitemlist).Text;
            Console.WriteLine("Menu: " + submenulist);

            actions.MoveToElement(driver.FindElement(subitemlist)).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(subsubitem));


            //SUB SUB ITEM 

            string subsubmenu = driver.FindElement(subsubitem).Text;
            Console.WriteLine("Menu: " + subsubmenu);

            actions.MoveToElement(driver.FindElement(subsubitem)).Perform();

            Thread.Sleep(1000);

        }

        public void SelectMenu(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,550)");

            //click SELECT MENU TAB from the side menu
            string textofbtn = driver.FindElement(selectmenuTab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(selectmenuTab).Click();

            //scroll UP
            scroll.ExecuteScript("window.scrollTo(0,-700)");

            wait.Until(ExpectedConditions.ElementIsVisible(selectvaluedropdown));

            //Select Value 
            driver.FindElement(selectvaluedropdown).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(selectoptions));

            driver.FindElement(selectoptions).Click();

            string selectedoptionsvalue = driver.FindElement(selectoptions).Text;
            Console.WriteLine("Selected Value: " + selectedoptionsvalue);


            //SELECT ONE 
            driver.FindElement(selectone).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(selectonevalue));

            driver.FindElement(selectonevalue).Click();
            string selectedonevalue = driver.FindElement(selectonevalue).Text;
            Console.WriteLine("Selected One Value: " + selectedonevalue);


            //SELECT OLD MENU 
            driver.FindElement(oldSelectMenu).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(selectoldSelectMenuValue));

            driver.FindElement(selectoldSelectMenuValue).Click();
            string oldSelectedvalue = driver.FindElement(selectoldSelectMenuValue).Text;
            Console.WriteLine("Selected One Value: " + oldSelectedvalue);

            //Multiselect drop down
            driver.FindElement(multiselectdropdown).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(multiselectvalue));

            driver.FindElement(multiselectvalue).Click();
            string multiselectvaluetxt = driver.FindElement(multiselectvalue).Text;
            Console.WriteLine("MultiSelect Value: " + multiselectvaluetxt);

        }

        public void Tabs(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,500)");

            //click TABS tab from the side menu
            string textofbtn = driver.FindElement(Tabstab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(Tabstab).Click();

            string heading = driver.FindElement(tabsheading).Text;
            Console.WriteLine("Heading: " + heading);

            //CLICK on the WHAT Tab
            string whatabheading = driver.FindElement(whattab).Text;
            Console.WriteLine("Tab: " + whatabheading);

            string whatabtxt = driver.FindElement(what).Text;
            Console.WriteLine("Text: " + whatabtxt);
            Console.WriteLine();

            //CLICK on the ORIGIN Tab
            string origintabheading = driver.FindElement(origin).Text;
            Console.WriteLine("Tab: " + origintabheading);

            driver.FindElement(origin).Click();


            string origintabtxt = driver.FindElement(origintxt).Text;
            Console.WriteLine("Text: " + origintabtxt);
            Console.WriteLine();

            //CLICK on the USE Tab
            string usetabheading = driver.FindElement(use).Text;
            Console.WriteLine("Tab: " + usetabheading);

            driver.FindElement(use).Click();


            string usetabtxt = driver.FindElement(usetxt).Text;
            Console.WriteLine("Text: " + usetabtxt);
            Console.WriteLine();

        }

        public void ProgressBar(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,400)");

            //click PROGRESS BAR TAB from the side menu
            string textofbtn = driver.FindElement(progressbartab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(progressbartab).Click();

            //scroll UP
            scroll.ExecuteScript("window.scrollTo(0,-400)");


            wait.Until(ExpectedConditions.ElementToBeClickable(startStopButton));

            string startbutton = driver.FindElement(startStopButton).Text;
            Console.WriteLine("Button: " + startbutton);

            driver.FindElement(startStopButton).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(resetButton));


            string resetbutton = driver.FindElement(resetButton).Text;
            Console.WriteLine("Button: " + resetbutton);


        }

        public void Slider(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            Actions actions = new Actions(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(headerimage));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);

            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,350)");

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //scroll down
            scroll.ExecuteScript("window.scrollTo(0,450)");

            //click SLIDER TAB from the side menu
            string textofbtn = driver.FindElement(sliderTab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(sliderTab).Click();

            //scroll UP
            scroll.ExecuteScript("window.scrollTo(0,-450)");


            wait.Until(ExpectedConditions.ElementIsVisible(rangebtn));

            //MOVE SLIDER
            actions.DragAndDropToOffset((IWebElement)rangebtn, 300, 400).Perform();


            Thread.Sleep(3000);






        }



    }
}
