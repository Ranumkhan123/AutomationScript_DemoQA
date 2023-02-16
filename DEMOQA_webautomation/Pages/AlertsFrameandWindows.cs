using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DEMOQA_webautomation.Pages
{
    public class AlertsFrameandWindows : CorePage
    {
        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By alertframewindow = By.XPath("//h5[normalize-space()='Alerts, Frame & Windows']");
        By browserwindow = By.XPath("//span[normalize-space()='Browser Windows']");
        By newtabButton = By.XPath("//button[@id='tabButton']");
        By newwindowButton = By.XPath("//button[@id='windowButton']");
        By newmessageWindowButton = By.XPath("//button[@id='messageWindowButton']");
        By tabNwindowmessage = By.XPath("//h1[@id='sampleHeading']");
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
        By modaldialoguetab = By.XPath("//span[normalize-space()='Modal Dialogs']");
        By modaldialogueheading = By.XPath("//div[normalize-space()='Click on button to see modal']");
        By smallModalButton = By.XPath("//button[@id='showSmallModal']");
        By largeModalButton = By.XPath("//button[@id='showLargeModal']");
        By smallmodalheader = By.XPath("//div[@id='example-modal-sizes-title-sm']");
        By smallmodaltext = By.XPath("//div[normalize-space()='This is a small modal. It has very less content']");
        By closeSmallModal = By.XPath("//button[@id='closeSmallModal']");
        By largemodalheader = By.XPath("//div[@id='example-modal-sizes-title-lg']");
        By largemodaltext = By.XPath("//p[contains(text(),'Lorem Ipsum is simply dummy text of the printing a')]");
        By closeLargeModal = By.XPath("//button[@id='closeLargeModal']");






        public void BrowserWindows(string url)
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

        public void Alerts(string url)
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

            ////click ALERTS FRAME AND WINDOW  
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

        public void ModalDialogs(string url)
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

            //click MODAL DIALOGUE TAB from the side menu
            string textofbtn = driver.FindElement(modaldialoguetab).Text;
            Console.WriteLine("Button: " + textofbtn);
            Console.WriteLine();
            driver.FindElement(modaldialoguetab).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(modaldialogueheading));
            string modalscreenheading = driver.FindElement(modaldialogueheading).Text;
            Console.WriteLine("Modal Screen: " + modalscreenheading);
            Console.WriteLine();


            //click SMALL MODAL
            string modalbuttontext = driver.FindElement(smallModalButton).Text;
            Console.WriteLine("Modal Button: " + modalbuttontext);
            driver.FindElement(smallModalButton).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(smallmodalheader));
            //SMALL MODAL HEADING
            string smallmodalheading = driver.FindElement(smallmodalheader).Text;
            Console.WriteLine("Small Modal Heading: " + smallmodalheader);
            //SMALL MODAL TEXT
            string smallmodaltextmsg = driver.FindElement(smallmodaltext).Text;
            Console.WriteLine("Small Modal Text: " + smallmodaltextmsg);
            Console.WriteLine();
            //CLOSE SMALL MODAL
            driver.FindElement(closeSmallModal).Click();



            //click LARGE MODAL
            string modalbuttontxt = driver.FindElement(largeModalButton).Text;
            Console.WriteLine("Modal Button: " + modalbuttontxt);
            driver.FindElement(largeModalButton).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(largemodalheader));
            //LARGE MODAL HEADING
            string largemodalheading = driver.FindElement(largemodalheader).Text;
            Console.WriteLine("Large Modal Heading: " + largemodalheading);
            //LARGE MODAL TEXT
            string largemodaltextmsg = driver.FindElement(largemodaltext).Text;
            Console.WriteLine("Large Modal Text: " + largemodaltextmsg);
            Console.WriteLine();
            //CLOSE LARGE MODAL
            driver.FindElement(closeLargeModal).Click();
        }




    }
}
