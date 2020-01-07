using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Common
{
   public class CommonPageObjects
    {
        public IWebDriver Driver;
        

       // public IWebDriver Driver;
        public IWebElement Buttondiv => Driver.FindElement(By.CssSelector("div[class='freebirdFormviewerViewNavigationButtons']"));
        public IList<IWebElement> ListBtn => Driver.FindElements(By.CssSelector("div[jscontroller='VXdfxd']"));
        public IWebElement NextBtn => ListBtn[1];
      
    }
}
