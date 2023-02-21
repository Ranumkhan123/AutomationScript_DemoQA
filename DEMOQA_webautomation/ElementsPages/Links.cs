using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOQA_webautomation.Pages
{
    public class Links : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By linkstab = By.XPath("//span[normalize-space()='Links']");
        By homelink = By.XPath("//a[@id='simpleLink']");
        By linkstabheading = By.XPath("//strong[normalize-space()='Following links will open new tab']");
        By homepageheaderimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By apilinkheading = By.XPath("//strong[normalize-space()='Following links will send an api call']");
        By createlink = By.XPath("//a[@id='created']");
        By nocontentlink = By.XPath("//a[@id='no-content']");
        By movedlink = By.XPath("//a[@id='moved']");
        By badrequestlink = By.XPath("//a[@id='bad-request']");
        By unauthorizedlink = By.XPath("//a[@id='unauthorized']");
        By forbiddenlink = By.XPath("//a[@id='forbidden']");
        By notfoundlink = By.XPath("//a[@id='invalid-url']");
        By linkresponse = By.XPath("//p[@id='linkResponse']");
        


        public void LinksTab(string url)
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

            //click LINKS TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,400)");
            driver.FindElement(linkstab).Click();
            string btnText = driver.FindElement(linkstab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();

            //Click on the HOME LINK
            string linkstabheadingmxg = driver.FindElement(linkstabheading).Text;
            Console.WriteLine("Heading: " + linkstabheadingmxg);
            driver.FindElement(homelink).Click();
            string homelinktext = driver.FindElement(homelink).Text;
            Console.WriteLine("Link: " + homelinktext);
            Console.WriteLine();
            wait.Until(ExpectedConditions.ElementExists(homepageheaderimage));

            //SWITCH BACK 
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);


            //API LINK 
            string apilinkmessagetext = driver.FindElement(apilinkheading).Text;
            Console.WriteLine("Heading: " + apilinkmessagetext);

            scroll.ExecuteScript("window.scrollTo(0,200)");

            //CREATE 
            driver.FindElement(createlink).Click();
            string createlinktext = driver.FindElement(createlink).Text;
            Console.WriteLine("Link: " + createlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //CREATE RESPONSE 
            string createresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("Create Response: " + createresponse);
            Console.WriteLine();


            //NO CONTENT 
            driver.FindElement(nocontentlink).Click();
            string nocontentlinktext = driver.FindElement(nocontentlink).Text;
            Console.WriteLine("Link: " + nocontentlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //NO CONTENT  RESPONSE 
            string nocontentresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("No Content Response: " + nocontentresponse);
            Console.WriteLine();

            //MOVED 
            driver.FindElement(movedlink).Click();
            string movedlinktext = driver.FindElement(movedlink).Text;
            Console.WriteLine("Link: " + movedlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //MOVED  RESPONSE 
            string movedlinkresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("No Content Response: " + movedlinkresponse);
            Console.WriteLine();


            //BAD REQUEST 
            driver.FindElement(badrequestlink).Click();
            string badrequestlinktext = driver.FindElement(badrequestlink).Text;
            Console.WriteLine("Link: " + badrequestlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //BAD REQUEST RESPONSE 
            string badrequestlinkresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("Bad Request Response: " + badrequestlinkresponse);
            Console.WriteLine();

            //UNAUTHORIZED
            driver.FindElement(unauthorizedlink).Click();
            string unauthorizelinktext = driver.FindElement(unauthorizedlink).Text;
            Console.WriteLine("Link: " + unauthorizelinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //UNAUTHORIZED RESPONSE 
            string unauthorizelinkresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("Unauthorize Response: " + unauthorizelinkresponse);
            Console.WriteLine();

            //FORBIDDEN
            driver.FindElement(forbiddenlink).Click();
            string forbiddenlinktext = driver.FindElement(forbiddenlink).Text;
            Console.WriteLine("Link: " + forbiddenlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //FORBIDDEN RESPONSE 
            string forbiddenlinkresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("Forbidden Response: " + forbiddenlinkresponse);
            Console.WriteLine();

            //NOT FOUND
            driver.FindElement(notfoundlink).Click();
            string notfoundlinktext = driver.FindElement(notfoundlink).Text;
            Console.WriteLine("Link: " + forbiddenlinktext);
            wait.Until(ExpectedConditions.ElementIsVisible(linkresponse));

            //NOT FOUND RESPONSE 
            string notfoundlinkresponse = driver.FindElement(linkresponse).Text;
            Console.WriteLine("Not Found Response: " + notfoundlinkresponse);
            Console.WriteLine();
        }

    }
}
