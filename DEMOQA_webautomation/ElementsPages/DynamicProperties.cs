using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.Pages
{
    public class DynamicProperties : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By dynamicpropertiestab = By.XPath("//span[normalize-space()='Dynamic Properties']");
        By enableafterfive = By.XPath("//button[@id='enableAfter']");
        By randomidtext = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/p");
        By visibleafterfive = By.XPath("//button[@id='visibleAfter']");













        public void DynamicPropertiesTab(string url)
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

            //click ELEMENTS 
            driver.FindElement(elementsbtn).Click();

            //click DYNAMIC PROPERTIES TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,600)");
            driver.FindElement(dynamicpropertiestab).Click();
            string btnText = driver.FindElement(dynamicpropertiestab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();

            //RANDOM TEXT 
            string randomidtextmessage = driver.FindElement(randomidtext).Text;
            Console.WriteLine("Random ID Text: " + randomidtextmessage);
            Console.WriteLine();

            //Click on the button ENABLE AFTER FIVE SEC
            wait.Until(ExpectedConditions.ElementToBeClickable(enableafterfive));
            driver.FindElement(enableafterfive).Click();
            string enablebtnText = driver.FindElement(enableafterfive).Text;
            Console.WriteLine("Enable Button: " + enablebtnText);
            Console.WriteLine();


            //Click on the button VISIBLE AFTER FIVE SEC
            wait.Until(ExpectedConditions.ElementToBeClickable(visibleafterfive));
            driver.FindElement(visibleafterfive).Click();
            string visiblebtntext = driver.FindElement(visibleafterfive).Text;
            Console.WriteLine("Visible Button: " + visiblebtntext);
            Console.WriteLine();

        }
    }
}
