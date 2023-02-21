using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.WidgetsPages
{
    public class Tabs : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
        By Tabstab = By.XPath("//span[normalize-space()='Tabs']");
        By tabsheading = By.XPath("//div[normalize-space()='Details about Lorem Ipsum']");
        By whattab = By.XPath("//a[@id='demo-tab-what']");
        By what = By.XPath("//p[contains(text(),'Lorem Ipsum is simply dummy text of the printing a')]");
        By origin = By.XPath("//a[@id='demo-tab-origin']");
        By origintxt = By.XPath("//p[contains(text(),'Contrary to popular belief, Lorem Ipsum is not sim')]");
        By use = By.XPath("//a[@id='demo-tab-use']");
        By usetxt = By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]");



        public void TabsTab(string url)
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

    }
}
