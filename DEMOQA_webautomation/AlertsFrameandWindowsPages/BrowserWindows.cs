using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation.AlertsFrameandWindowsPages
{
    public class BrowserWindows : CorePage
    {

        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By alertframewindow = By.XPath("//h5[normalize-space()='Alerts, Frame & Windows']");
        By browserwindow = By.XPath("//span[normalize-space()='Browser Windows']");
        By newtabButton = By.XPath("//button[@id='tabButton']");
        By newwindowButton = By.XPath("//button[@id='windowButton']");
        By newmessageWindowButton = By.XPath("//button[@id='messageWindowButton']");
        By tabNwindowmessage = By.XPath("//h1[@id='sampleHeading']");
        






        public void BrowserWindowsTab(string url)
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

            //click ALERTS FRAME AND WINDOW 
            driver.FindElement(alertframewindow).Click();

            //click BROWSER WINDOW TAB from the side menu
            string textofbtn = driver.FindElement(browserwindow).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();
            driver.FindElement(browserwindow).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(newtabButton));


            //NEW TAB 
            string newtabbtntext = driver.FindElement(newtabButton).Text;
            Console.WriteLine("Button: " + newtabbtntext);
            driver.FindElement(newtabButton).Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);


            //Move to NEW TAB Page
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(tabNwindowmessage, "This is a sample page"));
            string newtabscreenmessage = driver.FindElement(tabNwindowmessage).Text;
            Console.WriteLine("New Tab Text: " + newtabscreenmessage);
            Console.WriteLine();

            //Back to the MAIN page 
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);



            //NEW WINDOW 
            string newwindowbtntext = driver.FindElement(newwindowButton).Text;
            Console.WriteLine("Button: " + newwindowbtntext);
            driver.FindElement(newwindowButton).Click();

            //wait until page opens
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);

            //Move to NEW WINDOW Page
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(tabNwindowmessage, "This is a sample page"));
            string newwindowscreenmessage = driver.FindElement(tabNwindowmessage).Text;
            Console.WriteLine("New Window Text: " + newwindowscreenmessage);
            Console.WriteLine();

            //Back to the MAIN page 
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);



            //NEW MESSAGE WINDOW 
            string newmxgwindowbtntext = driver.FindElement(newmessageWindowButton).Text;
            Console.WriteLine("Button: " + newmxgwindowbtntext);
            driver.FindElement(newmessageWindowButton).Click();

            //wait until page opens
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);

            //Move to NEW MESSAGE WINDOW 
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Back to the MAIN page 
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

    }
}
