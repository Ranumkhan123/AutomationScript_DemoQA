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
    public class CheckBox : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");

        By checkboxtab = By.XPath("//span[normalize-space()='Check Box']");
        By home = By.XPath("//span[contains(text(),'Home')]");
        By resulthomecheckbox = By.XPath("//div[@id='result']");
       
     








        public void CheckBoxTab(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //scroll.ExecuteScript("window.scrollTo(0, 0)");
            //Action Actions = new Action(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;

            //wait screen visible
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
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

            //click CHECK BOX from the side menu
            driver.FindElement(checkboxtab).Click();
            string checkboxbtntext = driver.FindElement(checkboxtab).Text;
            Console.WriteLine("Button: " + checkboxbtntext);
            Console.WriteLine();

            //select Check Box
            wait.Until(ExpectedConditions.ElementIsVisible(home));
            driver.FindElement(home).Click();
            string checkboxresult = driver.FindElement(resulthomecheckbox).Text;
            Console.WriteLine("Result: " + checkboxresult);
            Console.WriteLine();
        }
    }
}
