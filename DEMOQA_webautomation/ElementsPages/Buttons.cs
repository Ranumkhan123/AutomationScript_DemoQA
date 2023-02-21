using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class Buttons : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By buttonstab = By.XPath("//span[normalize-space()='Buttons']");
        By buttonstabvisible = By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]");
        By doubleclickbtn = By.XPath("//button[@id='doubleClickBtn']");
        By rightclickbtn = By.XPath("//button[@id='rightClickBtn']");
        By clickbtn = By.XPath("//button[@id='CIVnc']");
        By doubleclickmessage = By.XPath("//p[@id='doubleClickMessage']");
        By rightclickbtnmessage = By.XPath("//p[@id='rightClickMessage']");
     



        public void ButtonsTab(string url)
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

            //click BUTTON TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(buttonstab).Click();
            string btnText = driver.FindElement(buttonstab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();


            //Click on the DOUBLE CLICK BUTTON
            scroll.ExecuteScript("window.scrollTo(0,150)");
            wait.Until(ExpectedConditions.ElementToBeClickable(doubleclickbtn));
            actions.MoveToElement(driver.FindElement(doubleclickbtn)).DoubleClick().Build().Perform();

            //DOUBLE CLICK ASSERTION
            string doubleclickbtnmxg = driver.FindElement(doubleclickmessage).Text;
            Assert.AreEqual("You have done a double click", doubleclickbtnmxg);
            Console.WriteLine("Double Click Message: " + doubleclickbtnmxg);


            //Click on the RIGHT CLICK BUTTON
            scroll.ExecuteScript("window.scrollTo(0,100)");
            actions.MoveToElement(driver.FindElement(rightclickbtn)).ContextClick().Build().Perform();


            //RIGHT CLICK ASSERTION
            string rightclickmessage = driver.FindElement(rightclickbtnmessage).Text;
            Assert.AreEqual("You have done a right click", rightclickmessage);
            Console.WriteLine("Right Click:" + rightclickmessage);

            /*
            //Click on the DYNAMIC CLICK BUTTON
            scroll.ExecuteScript("window.scrollTo(0,250)");
            actions.MoveToElement(driver.FindElement(clickbtn)).Build().Perform();

            //RIGHT CLICK ASSERTION
           string clickbtnmessage = driver.FindElement(clickmessage).Text;
           Assert.AreEqual("You have done a dynamic click", clickbtnmessage);
           Console.WriteLine("Dynamic Click:" + clickbtnmessage);
           Console.WriteLine();

*/
        }






    }
}
