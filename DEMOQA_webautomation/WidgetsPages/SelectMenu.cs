using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.WidgetsPages
{
    public class SelectMenu : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
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


        public void SelectMenuTab(string url)
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

    }
}
