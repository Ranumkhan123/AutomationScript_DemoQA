using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DEMOQA_webautomation.WidgetsPages
{
    public class Menu : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
        By menuTab = By.XPath("//span[normalize-space()='Menu']");
        By mainitem1 = By.XPath("//a[normalize-space()='Main Item 1']");
        By mainitem2 = By.XPath("//a[normalize-space()='Main Item 2']");
        By subitem = By.XPath("(//a[@href='#'][normalize-space()='Sub Item'])[1]");
        By subitemlist = By.XPath("//a[normalize-space()='SUB SUB LIST »']");
        By subsubitem = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/ul/li[1]/a");
       


        public void MenusTab(string url)
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
    }
}
