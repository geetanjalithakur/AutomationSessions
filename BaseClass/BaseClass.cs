using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions.BaseClass
{
    public class BaseClass
    {
       

      
        public IWebDriver InitializeDriver(string browser)
        {
            BrowserChoice selectbrowser = new BrowserChoice();
            IWebDriver driver = selectbrowser.chooseTheBrowser(browser);
            // Preparing the drivers for the use
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            return driver;

        }

        
        protected class BrowserChoice
        {

            enum Browser
            {
                Chrome,
                Firefox,
                Safari,
                Edge
            }
            public IWebDriver chooseTheBrowser(string browser)
            {
                browser = browser.Trim();
                if (browser == Convert.ToString(Browser.Edge))
                {
                    IWebDriver driver = new EdgeDriver();
                    return driver;
                }
                else if (browser == Convert.ToString(Browser.Firefox))
                {
                    IWebDriver driver = new FirefoxDriver();
                    return driver;
                }
                
                else
                {
                    IWebDriver driver = new ChromeDriver();
                    return driver;
                }

            }


        }
    }
}
