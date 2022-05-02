using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions
{
    class FDSHomePage
    {
        private IWebDriver _driver;

        public FDSHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ComboBoxToolSelector => _driver.FindElement(By.XPath("//input[@role='combobox']"));
   
    
    }
  
}
