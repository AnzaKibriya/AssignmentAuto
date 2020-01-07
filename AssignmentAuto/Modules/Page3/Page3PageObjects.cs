using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page3
{
    class Page3PageObjects
    {
        public IWebDriver Driver;
        #region properties

        public IWebElement Question1 => Driver.FindElement(By.CssSelector("div[id='i1']"));
        public IWebElement Question2 => Driver.FindElement(By.CssSelector("div[id='i20']"));
        public IWebElement Answer1Div => Driver.FindElement(By.CssSelector("div[aria-labelledby='i1']"));
        public IWebElement Answer2Div => Driver.FindElement(By.CssSelector("div[aria-labelledby='i20']"));
        public IList<IWebElement> Answer1List => Answer1Div.FindElements(By.ClassName("freebirdFormviewerViewItemsCheckboxChoice"));
        public IList<IWebElement> Answer2List => Answer2Div.FindElements(By.ClassName("freebirdFormviewerViewItemsCheckboxChoice"));
        public IWebElement Buttondiv => Driver.FindElement(By.CssSelector("div[class='freebirdFormviewerViewNavigationButtons']"));
        public IList<IWebElement> ListBtn => Driver.FindElements(By.CssSelector("div[jscontroller='VXdfxd']"));
        public IWebElement NextBtn => ListBtn[1];
        #endregion
        public void scrolldown(IWebElement locator)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", locator);

        }
    }
}
