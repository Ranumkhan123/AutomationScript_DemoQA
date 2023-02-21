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
    public class Alerts : CorePage
    {

        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By alertframewindow = By.XPath("//h5[normalize-space()='Alerts, Frame & Windows']");
        By alertstab = By.XPath("//span[normalize-space()='Alerts']");
        By alertsscreenvisible = By.XPath("//div[@id='javascriptAlertsWrapper']");
        By alertButtontext = By.XPath("//span[normalize-space()='Click Button to see alert']");
        By alertButton = By.XPath("//button[@id='alertButton']");
        By timerAlerttext = By.XPath("//span[normalize-space()='On button click, alert will appear after 5 seconds']");
        By timerAlertButton = By.XPath("//button[@id='timerAlertButton']");
        By confirmAlertText = By.XPath("//span[normalize-space()='On button click, confirm box will appear']");
        By confirmAlertButton = By.XPath("//button[@id='confirmButton']");
        By confirmAlertResult = By.XPath("//span[@id='confirmResult']");
        By promptAlertHeading = By.XPath("//span[normalize-space()='On button click, prompt box will appear']");
        By promptAlertButton = By.XPath("//button[@id='promtButton']");
        By promptAlertResult = By.XPath("//span[@id='promptResult']");
       


        public void AlertsTab(string url)
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

            //click ALERTS TAB from the side menu
            string textofbtn = driver.FindElement(alertstab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();
            driver.FindElement(alertstab).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(alertsscreenvisible));

            //ALERT ONE
            string alertoneheading = driver.FindElement(alertButtontext).Text;
            Console.WriteLine("Alert Heading: " + alertoneheading);

            driver.FindElement(alertButton).Click();

            // Switch the control of 'driver' to the Alert from main window
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            // Get the Text of Alert
            String alertText = confirmationAlert.Text;
            Console.WriteLine("Alert text is: " + alertText);
            Console.WriteLine();

            //Accept Alert 
            driver.SwitchTo().Alert().Accept();

            //TIMER ALERT 
            string timerAlertheading = driver.FindElement(timerAlerttext).Text;
            Console.WriteLine("Timer Alert Heading: " + timerAlertheading);

            driver.FindElement(timerAlertButton).Click();

            //wait for alert to present
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

            // Switch the control of 'driver' to the Alert from main window
            IAlert timerAlert = driver.SwitchTo().Alert();

            // Get the Text of Alert
            String timerAlertText = timerAlert.Text;
            Console.WriteLine("Timer Alert text is: " + timerAlertText);
            Console.WriteLine();

            //Accept TIMER ALERT 
            driver.SwitchTo().Alert().Accept();



            //CONFIRM ALERT 
            string confirmAlertheading = driver.FindElement(confirmAlertText).Text;
            Console.WriteLine("Confirm Alert Heading: " + confirmAlertheading);

            driver.FindElement(confirmAlertButton).Click();

            //wait for CONFIRM alert to present
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

            // Switch the control of 'driver' to the Alert from main window
            IAlert confirmAlert = driver.SwitchTo().Alert();

            // Get the Text of CONFIRM Alert
            String confirmAlertboxText = confirmAlert.Text;
            Console.WriteLine("Confirm Alert text is: " + confirmAlertboxText);

            //Accept CONFIRM ALERT 
            driver.SwitchTo().Alert().Dismiss();

            //CONFIRM ALERT Text 
            string cofirmAlertResultMsg = driver.FindElement(confirmAlertResult).Text;
            Console.WriteLine("Confirm Alert Result: " + cofirmAlertResultMsg);
            Console.WriteLine();



            //PROMPT ALERT 
            string promptAlertheading = driver.FindElement(promptAlertHeading).Text;
            Console.WriteLine("Confirm Alert Heading: " + promptAlertheading);

            driver.FindElement(promptAlertButton).Click();

            //wait for PROMPT alert to present
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

            // Switch the control of 'driver' to the Alert from main window
            IAlert promptAlert = driver.SwitchTo().Alert();

            // Get the Text of PROMPT Alert
            String promptAlertboxText = promptAlert.Text;
            Console.WriteLine("Prompt Alert text is: " + promptAlertboxText);

            //Enter TEXT in PROMPT Alert
            promptAlert.SendKeys("Ranum Khan");

            //Accept PROMPT ALERT 
            driver.SwitchTo().Alert().Accept();

            //PROMPT ALERT Text 
            string promptAlertResultMsg = driver.FindElement(promptAlertResult).Text;
            Console.WriteLine("Prompt Alert Result: " + promptAlertResultMsg);
            Console.WriteLine();

        }







    }
}
