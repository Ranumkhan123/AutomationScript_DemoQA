using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQA_webautomation
{
    public class CorePage
    {
        public static IWebDriver driver;

        public static IWebDriver SeleniumInit()
        {

            var chromeOptions = new ChromeOptions();
            //   chromeOptions.AddArgument("--incognito");


            IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
            driver = chromeDriver;
            return driver;

        }

    }
}
