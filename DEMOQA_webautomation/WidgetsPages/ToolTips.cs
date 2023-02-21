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

namespace DEMOQA_webautomation.WidgetsPages
{
    public class ToolTips : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");

        By tooltiptab = By.XPath("//span[normalize-space()='Tool Tips']");
        By tooltipheading = By.XPath("//p[normalize-space()='Practice Tool Tips']");
        By hoverButton = By.XPath("//button[@id='toolTipButton']");
        By hoveredtxt = By.XPath("//div[contains(text(),'You hovered over the Button')]");
        By menuTab = By.XPath("//span[normalize-space()='Menu']");


        public void ToolTipsTab(string url)
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

    }
}
