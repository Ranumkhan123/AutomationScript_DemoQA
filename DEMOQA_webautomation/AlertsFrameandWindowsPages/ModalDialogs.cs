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
    public class ModalDialogs : CorePage
    {

        By headerimage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        By alertframewindow = By.XPath("//h5[normalize-space()='Alerts, Frame & Windows']");
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












        public void ModalDialogsTab(string url)
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
