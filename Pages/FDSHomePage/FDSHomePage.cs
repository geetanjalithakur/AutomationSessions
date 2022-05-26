using AutomationSessions.Config;
using AutomationSessions.Interface;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions
{
    public class FDSHomePage// : XpathOfTableElements
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
        protected IList<IWebElement> SelectedPages => _driver.FindElements(By.XPath("//li/a[@class='k-link k-state-selected']]]"));
        protected IList<IWebElement> NoOfRowsFdsHome => _driver.FindElements(By.XPath("//tr[@data-kendo-grid-item-index]"));
       protected IList<IWebElement> NoOfColumnsFdsHome => _driver.FindElements(By.XPath("//tr[@data-kendo-grid-item-index='0']/td[@data-kendo-grid-column-index='0']/a"));
        protected IWebElement GotoNextPage => _driver.FindElement(By.XPath("//kendo-pager-next-buttons/a[@title='Go to the next page']"));
       
        protected IWebElement GotoPreviousPage => _driver.FindElement(By.XPath("//kendo-pager-prev-buttons/a[@title='Go to the previous page']"));
        protected IWebElement GotoTheLastPage => _driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
        protected IWebElement GotoTheFirstPage => _driver.FindElement(By.XPath("//a[@title='Go to the first page']"));
        protected IWebElement FirstPage => _driver.FindElement(By.XPath("//li/a[@aria-label='Page 1']"));
        protected IWebElement PagesPerPage => _driver.FindElement(By.XPath("//kendo-pager-info[@class='k-pager-info k-label']"));



        protected string[] xpaths = { "//tr[{0}]/td/a[@title='Manage SEED Associations']",
            "//tr[{0}]/td/a[@title ='FDS Builder'] ",
            "//tr[{0}]/td/a[@title ='Fds Tool SEED']" };

        public Dictionary<string, string> dicOfTableElements { get; set; }
        protected void rowsandcolumns()
        {
            XpathOfTableElements xpathOfTable = new XpathOfTableElements();
            dicOfTableElements = xpathOfTable.tableElements(NoOfRowsFdsHome.Count, NoOfColumnsFdsHome.Count, xpaths);
        }
        public void ShouldPaginationWork()

        {
          
            try
            {
                if (SelectedPages.Count > 1)
                {
                    throw new Exception("Multiple pages are selected");
                }
               else if(SelectedPages.Count==0)
                {
                    throw new Exception("Didn't select any page");
                }
                int pagenumber = Convert.ToInt32(SelectedPages[0].Text);
                  
                GotoNextPage.Click();
                if(SelectedPages.Count > 1)
                {
                    throw new Exception("Multiple pages are selected after click on the Next button");
                }
                else if (SelectedPages.Count==0)
                {
                    throw new Exception("Didn't select any page after clicking on nextPage");
                }
                int nextPageNumber = Convert.ToInt32(SelectedPages[0].Text);
                Assert.Equals(pagenumber++, nextPageNumber);

                GotoPreviousPage.Click();
                if(SelectedPages.Count > 1)
                {
                    throw new Exception("Multiple pages are selected after click on the Prevoius button");
                }
                else if (SelectedPages.Count == 0)
                {
                    throw new Exception("Didn't select any page after clicking on PreviousPage");
                }
                int goToPreviousPage = Convert.ToInt32(SelectedPages[0].Text);  
                Assert.Equals(pagenumber--, goToPreviousPage);    
            }
           


            catch (Exception e)
            {

                throw;
            }
        }

       

    }
}










