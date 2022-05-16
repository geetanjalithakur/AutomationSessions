using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSessions.Config
{
    class XpathOfTableElements
    {
        // Returns dictionary of XpathOf TableElements with Row incrementing in XPath
        public Dictionary<string, string> tableElements(int rows, int columns, string[] xpaths)
        {
            Dictionary<string, string> dictionaryOfXpathElements = new Dictionary<string, string>();

            string xPathofElement;
           
            
            for (int i = 1; i <= rows; i++)
            {
                int ctr = 0;
                for (int j = 1; j <= columns; j++)
                {
                    xPathofElement = string.Format(xpaths[ctr], i);
                    dictionaryOfXpathElements.Add(i + ":" + j, xPathofElement);
                    ctr++;
                }
            }
            return dictionaryOfXpathElements;
        }
    }
}
