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
    public class ProgressBar : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
        By usetxt = By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]");
        By progressbartab = By.XPath("//span[normalize-space()='Progress Bar']");
        By startStopButton = By.XPath("//button[@id='startStopButton']");
        By progressbar = By.XPath("//div[@id='progressBar']");
        By resetButton = By.XPath("//button[@id='resetButton']");
        By sliderTab = By.XPath("//span[normalize-space()='Slider']");
        By rangeslider = By.XPath("//input[@type='range']");
        By sliderValue = By.XPath("//input[@id='sliderValue']");

        public void ProgressBarTab(string url)
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
            scroll.ExecuteScript("window.scrollTo(0,400)");

            //click PROGRESS BAR TAB from the side menu
            string textofbtn = driver.FindElement(progressbartab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();

            driver.FindElement(progressbartab).Click();

            //scroll UP
            scroll.ExecuteScript("window.scrollTo(0,-400)");


            wait.Until(ExpectedConditions.ElementToBeClickable(startStopButton));

            string startbutton = driver.FindElement(startStopButton).Text;
            Console.WriteLine("Button: " + startbutton);

            driver.FindElement(startStopButton).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(resetButton));


            string resetbutton = driver.FindElement(resetButton).Text;
            Console.WriteLine("Button: " + resetbutton);


        }
    }
}
