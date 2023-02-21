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
    public class WebTables : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By elementsbtn = By.XPath("//h5[normalize-space()='Elements']");
        By checkboxtab = By.XPath("//span[normalize-space()='Check Box']");
        By home = By.XPath("//span[contains(text(),'Home')]");
        By resulthomecheckbox = By.XPath("//div[@id='result']");
        By radiobtn = By.XPath("//span[normalize-space()='Radio Button']");
        By selectradiobtn = By.XPath("//label[normalize-space()='Impressive']");
        By textafterradiobtnselect = By.XPath("//span[normalize-space()='Impressive']");
        By webtablesbtn = By.XPath("//span[normalize-space()='Web Tables']");
        By addnewrecordbtn = By.XPath("//button[@id='addNewRecordButton']");
        By firstName = By.XPath("//input[@id='firstName']");
        By lastName = By.XPath("//input[@id='lastName']");
        By email = By.XPath("//input[@id='userEmail']");
        By age = By.XPath("//input[@id='age']");
        By salary = By.XPath("//input[@id='salary']");
        By department = By.XPath("//input[@id='department']");
        By submitbutton = By.XPath("//button[@id='submit']");
        By newrecordmodal = By.XPath("//body/div[@role='dialog']/div[@role='document']/div/div[1]");
        By editrecordbtn = By.XPath("//span[@id='edit-record-4']");
        By deleterecord = By.XPath("//span[@id='delete-record-4']//*[name()='svg']");
        string fname = "test";
        string lname = "abc";
        string enteremail = "test@malinator.com";
        string enterage = "25";
        string entersalary = "110000";
        string enterdepartment = "QA";


        By submitbtn = By.XPath("//button[@id='submit']");







        public void WebTablesTab(string url)
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

            //click WEB TABLES BUTTON from the side menu
            driver.FindElement(webtablesbtn).Click();
            string btnText = driver.FindElement(webtablesbtn).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();

            //Click on the ADD button
            driver.FindElement(addnewrecordbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(newrecordmodal));

            //fill the details
            driver.FindElement(firstName).SendKeys(fname);
            driver.FindElement(lastName).SendKeys(lname);
            driver.FindElement(email).SendKeys(enteremail);
            driver.FindElement(age).SendKeys(enterage);
            driver.FindElement(salary).SendKeys(entersalary);
            driver.FindElement(department).SendKeys(enterdepartment);
            driver.FindElement(submitbutton).Click();

            Console.WriteLine("First Name: " + fname);
            Console.WriteLine("Last Name: " + lname);
            Console.WriteLine("User Email: " + enteremail);
            Console.WriteLine("First Name: " + fname);
            Console.WriteLine("Age: " + enterage);
            Console.WriteLine("Salary: " + entersalary);
            Console.WriteLine("Department: " + enterdepartment);
            Console.WriteLine();

            string editlastname = "XYZ";
            //EDIT record
            driver.FindElement(editrecordbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(newrecordmodal));
            driver.FindElement(lastName).Clear();
            driver.FindElement(lastName).SendKeys(editlastname);
            driver.FindElement(submitbtn).Click();

            Console.WriteLine("Last Name (edit): " + editlastname);
            Console.WriteLine();

            //Delete Record
            driver.FindElement(deleterecord).Click();
        }

    }
}
