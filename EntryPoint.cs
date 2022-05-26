using OpenQA.Selenium;
using System;
using AutomationSessions.Actions;
using System.Threading;

namespace AutomationSessions
{
    class EntryPoint 
    {
        public static void Main()
        {
           
            BaseClass.BaseClass baseclass = new BaseClass.BaseClass();
           IWebDriver driver = baseclass.InitializeDriver("Chrome");
            driver.Navigate().GoToUrl(BaseClass.BaseVariables.homepageUrl);

            FDSHomeAction action = new FDSHomeAction(driver);
            action.clickManageSeedAssociation();
            Thread.Sleep(2000);
            driver.Quit();
        }

    }
}
