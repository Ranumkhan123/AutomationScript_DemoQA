using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.Pages
{
    public class RadioButton : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By radiobtn = By.XPath("//span[normalize-space()='Radio Button']");
        By selectradiobtn = By.XPath("//label[normalize-space()='Impressive']");
        By textafterradiobtnselect = By.XPath("//span[normalize-space()='Impressive']");
        







        public void RadioButtonTab(string url)
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

            //click RADIO BUTTON from the side menu
            driver.FindElement(radiobtn).Click();
            string btnText = driver.FindElement(radiobtn).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();

            driver.FindElement(selectradiobtn).Click();
            string radiobtnText = driver.FindElement(textafterradiobtnselect).Text;
            Console.WriteLine("You have selected: " + radiobtnText);

        }

    }
}
