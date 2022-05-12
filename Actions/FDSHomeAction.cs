using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationSessions.Actions
{
    class FDSHomeAction:FDSHomePage
    {
        private IWebDriver _driver;

        public FDSHomeAction(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }
        //public void clickAddLspButton()=> AddLSPButton.Click();
      
       //function to add Lspbutton 
        public Boolean clickAddLSPButton()
        {
            try
            {
                AddLSPButton.Click();
                return true;
            }
            catch (Exception e)
            {
                return false;
               // throw;
            }
        }




        public string getLspButtonText() => AddLSPButton.Text.Trim();

      // " Add New LSP tool"=" Add New LSP tool"



    }
}
