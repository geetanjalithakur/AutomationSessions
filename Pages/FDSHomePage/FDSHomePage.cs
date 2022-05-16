using AutomationSessions.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions
{
    class FDSHomePage: IRowColumns
    {
        private IWebDriver _driver;

        public FDSHomePage(IWebDriver driver)
        {
            _driver = driver;
            TableElements();
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

        //Gives me the elementsof rows
        protected IList<IWebElement> NoOfRowsFdsHome => _driver.FindElements(By.XPath("//tr[@data-kendo-grid-item-index]"));


        public Dictionary<string, string> dictionaryOfFdsHomePage { get; set; } = new Dictionary<string, string>();
        public void TableElements()
        {
            string xPathofElement;
            for (int i = 1; i <= NoOfRowsFdsHome.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (j == 1)
                    {
                        xPathofElement = String.Format("//tr[{0}]/td/a[@title='Manage SEED Associations']", i);
                        dictionaryOfFdsHomePage.Add(i + ":" + j, xPathofElement);
                    }

                    if (j == 2)
                    {
                        xPathofElement = String.Format("//tr[{0}]/td/a[@title ='FDS Builder']", i);
                        dictionaryOfFdsHomePage.Add(i + ":" + j, xPathofElement);
                    }

                    if (j == 3)
                    {
                        xPathofElement = String.Format("//tr[1]/td/a[@title ='Fds Tool SEED']", i);
                        dictionaryOfFdsHomePage.Add(i + ":" + j, xPathofElement);
                    }
                }
            }
        }

       
        
    }



}


