using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.Pages
{
    public class BrokenLinks : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']"); By brokenlinkstab = By.XPath("//span[normalize-space()='Broken Links - Images']");
        By validlink = By.XPath("//a[normalize-space()='Click Here for Valid Link']");
        By invalidlink = By.XPath("//a[normalize-space()='Click Here for Broken Link']");
        By invalidlinkscreentext = By.XPath("//div[@id='content']");
        By dynamicpropertiestab = By.XPath("//span[normalize-space()='Dynamic Properties']");
        By enableafterfive = By.XPath("//button[@id='enableAfter']");
        By randomidtext = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/p");
        By visibleafterfive = By.XPath("//button[@id='visibleAfter']");







        public void BrokenLinksTab(string url)
        {
            //scroll
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            //actions class
            Actions actions = new Actions(driver);
            //wait 
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
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

            //click ELEMENTS 
            driver.FindElement(elementsbtn).Click();

            //click BROKEN LINKS TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,500)");
            driver.FindElement(brokenlinkstab).Click();
            string btnText = driver.FindElement(brokenlinkstab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();


            //Click on the VALID LINK 
            string validlinktext = driver.FindElement(validlink).Text;
            Console.WriteLine("Valid Link Text: " + validlinktext);
            Console.WriteLine();
            driver.FindElement(validlink).Click();

            //Navigate back to the page
            driver.Navigate().Back();


            //Click on the INVALID LINK 
            scroll.ExecuteScript("window.scrollTo(0,300)");
            string invalidlinktext = driver.FindElement(invalidlink).Text;
            Console.WriteLine("Invalid Link Text: " + invalidlinktext);
            Console.WriteLine();
            driver.FindElement(invalidlink).Click();


            //INVALID LINK Text
            wait.Until(ExpectedConditions.ElementIsVisible(invalidlinkscreentext));
            string invalidscreentext = driver.FindElement(invalidlinkscreentext).Text;
            Console.WriteLine("Invalid Screen Text: " + invalidscreentext);
            Console.WriteLine();

            //Navigate back to the page
            driver.Navigate().Back();
        }
    }
}
