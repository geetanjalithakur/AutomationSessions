using AutomationSessions.Config;
using AutomationSessions.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions
{
    class FDSHomePage : XpathOfTableElements
    {
        private IWebDriver _driver;

        public FDSHomePage(IWebDriver driver)
        {
            _driver = driver;
            rowsandcolumns();
        }

        //Add New LSP Tool button
        protected IWebElement AddLSPButton => _driver.FindElement(By.XPath("//button[contains(text (), 'Add New LSP tool')]]"));
        protected IWebElement AddRPButton => _driver.FindElement(By.XPath("//button[contains(text(), ' Add New RP tool')]"));
        protected IWebElement SearchBox => _driver.FindElement(By.XPath("//input[@laceholder='Search'"));
        protected IWebElement ManageSeedAssociationHome => _driver.FindElement(By.XPath("//tr[1]/td/a[@title='Manage SEED Associations']"));
        protected IWebElement FDSBuilderButtonHome => _driver.FindElement(By.XPath("//tr[1]/td/a[@title ='FDS Builder']"));
        protected IWebElement FDSToolSeed => _driver.FindElement(By.XPath("//tr[1]/td/a[@title ='Fds Tool SEED']"));
        protected IWebElement EditButton => _driver.FindElement(By.XPath("//td[13]/a[@title='Edit']]"));
        protected IWebElement DeleteButton => _driver.FindElement(By.XPath("//td[13]/a[@title='Delete']]]"));
        protected IWebElement AddPocButton => _driver.FindElement(By.XPath("//button[contains(text(), 'Add POCs ')]"));
        protected IWebElement BulkLoadAllCircuits => _driver.FindElement(By.XPath("//button[contains(text(),'Bulk Load All Circuits')])]"));
        protected IWebElement DeleteButtonBuilderPage => _driver.FindElement(By.XPath("//button[@value='Delete']"));
        protected IWebElement FPCPOC => _driver.FindElement(By.XPath("//button[@title='Facility power cable' and @value='FPC']]"));


        private void rowsandcolumns()
        {
                protected IList<IWebElement> NoOfRowsFdsHome => _driver.FindElements(By.XPath("//tr[@data-kendo-grid-item-index]"));
             protected IList<IWebElement> NoOfColumnsFdsHome => _driver.FindElements(By.XPath(""));

             protected string[] xpaths = { "//tr[{0}]/td/a[@title='Manage SEED Associations']",
            "//tr[{0}]/td/a[@title ='FDS Builder'] ",
            "//tr[{0}]/td/a[@title ='Fds Tool SEED']" };

         }




            XpathOfTableElements abc = new XpathOfTableElements();
    public Dictionary<string, string> TableDictionary = abc.tableElements(NoOfRowsFdsHome.Count, NoOfColumnsFdsHome.Count, xpaths);




    }
}   
   


        





