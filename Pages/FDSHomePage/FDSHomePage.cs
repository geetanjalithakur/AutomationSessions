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

        //Add New LSP Tool button
         protected IWebElement AddLSPButton => _driver.FindElement(By.XPath("//button[contains(text (), 'Add New LSP tool')]]"));
        protected IWebElement AddRPButton => _driver.FindElement(By.XPath("//button[contains(text(), ' Add New RP tool')]"));
        protected IWebElement SearchBox => _driver.FindElement(By.XPath("//input[@laceholder='Search'"));
        protected IWebElement ManageSeedAssociationHome=> _driver.FindElement(By.XPath("//tr[1]/td/a[@title='Manage SEED Associations']"));
        protected IWebElement FDSBuilderButtonHome => _driver.FindElement(By.XPath("//tr[1]/td/a[@title ='FDS Builder']"));
        protected IWebElement FDSBuilderButtonHome => _driver.FindElement(By.XPath("//tr[1]/td/a[@title ='FDS Builder']"));





        ///button[text ()= ' Add New LSP tool'] <summary>
        /// button[text ()= ' Add New RP tool']
        /// </summary>
        public void xpathe()
        {
            for (int i = 1; i <= 20; i++)
            {
                //string xpath = "//tr[3]/td/a[@title='Manage SEED Associations']";

             string xpath=   String.Format("//tr[{0}]/td/a[@title='Manage SEED Associations']", i);

        }
       

            }



}

}
