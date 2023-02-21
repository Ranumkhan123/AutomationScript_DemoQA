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
    public class Accordian : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By widgets = By.XPath("//h5[normalize-space()='Widgets']");
        By accordiantab = By.XPath("//span[normalize-space()='Accordian']");
        By section1Heading = By.XPath("//div[@id='section1Heading']");
        By section1Text = By.XPath("//p[contains(text(),'Lorem Ipsum is simply dummy text of the printing a')]");
        By section2Heading = By.XPath("//div[@id='section2Heading']");
        By section2Text = By.XPath("//p[contains(text(),'Contrary to popular belief, Lorem Ipsum is not sim')]");
        By section3Heading = By.XPath("//div[@id='section3Heading']");
        By section3Text = By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]");
       



        public void AccordianTab(string url)
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

            //click WIDGETS 
            driver.FindElement(widgets).Click();

            //click Accordian TAB from the side menu
            string textofbtn = driver.FindElement(accordiantab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();
            driver.FindElement(accordiantab).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(section1Heading));

            //SECTION 1 
            string section1heading = driver.FindElement(section1Heading).Text;
            Console.WriteLine("Section One: " + section1heading);

            string section1text = driver.FindElement(section1Text).Text;
            Console.WriteLine(section1text);
            Console.WriteLine();

            driver.FindElement(section1Heading).Click();


            //SECTION 2
            driver.FindElement(section2Heading).Click();

            string section2heading = driver.FindElement(section2Heading).Text;
            Console.WriteLine("Section Two: " + section2heading);

            string section2text = driver.FindElement(section2Text).Text;
            Console.WriteLine(section2text);
            Console.WriteLine();



            //SECTION 3
            scroll.ExecuteScript("window.scrollTo(0, 400)");
            driver.FindElement(section3Heading).Click();

            string section3heading = driver.FindElement(section3Heading).Text;
            Console.WriteLine("Section Three: " + section3heading);

            string section3text = driver.FindElement(section3Text).Text;
            Console.WriteLine(section3text);
            Console.WriteLine();
        }

    }
}
