using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DEMOQA_webautomation.Pages
{
    public class TextBox : CorePage
    {

        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By textboxbtn = By.XPath("//span[normalize-space()='Text Box']");
        By username = By.XPath("//input[@id='userName']");
        By useremail = By.XPath("//input[@id='userEmail']");
        By currentaddress = By.XPath("//textarea[@id='currentAddress']");
        By permanentaddress = By.XPath("//textarea[@id='permanentAddress']");
        By submitbtn = By.XPath("//button[@id='submit']");

        string userName = "Abc";
        string userEmail = "abc@malinator.com";
        string currentAddress = "xyz12, 3a, tdf";
        string permanentAddress = "xyz12, 3a, tdf";

        By details = By.XPath("//div[@id='output']//div");



        public void TextBoxTab(string url)
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

            //click ELEMENTS 
            driver.FindElement(elementsbtn).Click();

            //click TEXT BOX from the side menu
            driver.FindElement(textboxbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(username));
            string textofbtn = driver.FindElement(textboxbtn).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();


            //fill the FROM
            driver.FindElement(username).SendKeys(userName);
            driver.FindElement(useremail).SendKeys(userEmail);
            driver.FindElement(currentaddress).SendKeys(currentAddress);
            driver.FindElement(permanentaddress).SendKeys(permanentAddress);
            scroll.ExecuteScript("window.scrollTo(0, 200)");
            wait.Until(ExpectedConditions.ElementToBeClickable(submitbtn));
            driver.FindElement(submitbtn).Click();


            //Print all the details
            scroll.ExecuteScript("window.scrollTo(0, 300)");
            string formdetails = driver.FindElement(details).Text;
            Console.WriteLine("Form Details: " + formdetails);
            Console.WriteLine();

        }



    }
}
