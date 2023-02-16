using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace DEMOQA_webautomation.Pages
{
    public class ElementsScreens : CorePage
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

        By buttonstab = By.XPath("//span[normalize-space()='Buttons']");
        By buttonstabvisible = By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]");
        By doubleclickbtn = By.XPath("//button[@id='doubleClickBtn']");
        By rightclickbtn = By.XPath("//button[@id='rightClickBtn']");
        By clickbtn = By.XPath("//button[@id='CIVnc']");
        By doubleclickmessage = By.XPath("//p[@id='doubleClickMessage']");
        By rightclickbtnmessage = By.XPath("//p[@id='rightClickMessage']");
        By clickmessage = By.XPath("//p[@id='dynamicClickMessage']");
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
        By brokenlinkstab = By.XPath("//span[normalize-space()='Broken Links - Images']");
        By validlink = By.XPath("//a[normalize-space()='Click Here for Valid Link']");
        By invalidlink = By.XPath("//a[normalize-space()='Click Here for Broken Link']");
        By invalidlinkscreentext = By.XPath("//div[@id='content']");
        By dynamicpropertiestab = By.XPath("//span[normalize-space()='Dynamic Properties']");
        By enableafterfive = By.XPath("//button[@id='enableAfter']");
        By randomidtext = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/p");
        By visibleafterfive = By.XPath("//button[@id='visibleAfter']");

        public void TextBox(string url)
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

        public void CheckBox(string url)
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

        public void RadioButton(string url)
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

        public void WebTables(string url)
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
            driver.FindElement(submitbtn).Click();

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

        public void Buttons(string url)
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

        public void Links(string url)
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

        public void BrokenLinks(string url)
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

            //click BROKEN LINKS TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,500)");
            driver.FindElement(brokenlinkstab).Click();
            string btnText = driver.FindElement(brokenlinkstab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();


            //Click on the VALID LINK 
            string validlinktext = driver.FindElement(validlink).Text;
            Console.WriteLine("Valid Link Text: " + validlinktext);
            Console.WriteLine();
            driver.FindElement(validlink).Click();

            //Navigate back to the page
            driver.Navigate().Back();


            //Click on the INVALID LINK 
            scroll.ExecuteScript("window.scrollTo(0,350)");
            string invalidlinktext = driver.FindElement(invalidlink).Text;
            Console.WriteLine("Invalid Link Text: " + invalidlinktext);
            Console.WriteLine();
            driver.FindElement(invalidlink).Click();

            //INVALID LINK Text
            wait.Until(ExpectedConditions.ElementIsVisible(invalidlinkscreentext));
            string invalidscreentext = driver.FindElement(invalidlinkscreentext).Text;
            Console.WriteLine("Invalid Screen Text: " + invalidscreentext);
            Console.WriteLine();

            //Navigate back to the page
            driver.Navigate().Back();
        }

        public void DynamicProperties(string url)
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

            //click DYNAMIC PROPERTIES TAB from the side menu
            scroll.ExecuteScript("window.scrollTo(0,600)");
            driver.FindElement(dynamicpropertiestab).Click();
            string btnText = driver.FindElement(dynamicpropertiestab).Text;
            Console.WriteLine("Button: " + btnText);
            Console.WriteLine();

            //RANDOM TEXT 
            string randomidtextmessage = driver.FindElement(randomidtext).Text;
            Console.WriteLine("Random ID Text: " + randomidtextmessage);
            Console.WriteLine();

            //Click on the button ENABLE AFTER FIVE SEC
            wait.Until(ExpectedConditions.ElementToBeClickable(enableafterfive));
            driver.FindElement(enableafterfive).Click();
            string enablebtnText = driver.FindElement(enableafterfive).Text;
            Console.WriteLine("Enable Button: " + enablebtnText);
            Console.WriteLine();


            //Click on the button VISIBLE AFTER FIVE SEC
            wait.Until(ExpectedConditions.ElementToBeClickable(visibleafterfive));
            driver.FindElement(visibleafterfive).Click();
            string visiblebtntext = driver.FindElement(visibleafterfive).Text;
            Console.WriteLine("Visible Button: " + visiblebtntext);
            Console.WriteLine();

        }
    }
}