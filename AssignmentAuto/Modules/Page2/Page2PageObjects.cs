using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page2
{
    class Page2PageObjects
    {
        public IWebDriver Driver;
        public IWebElement Question1 => Driver.FindElement(By.CssSelector("div[id='i1']"));
        public IList<IWebElement> Container => Driver.FindElements(By.ClassName("freebirdFormviewerViewNumberedItemContainer"));
        public IList<IWebElement> Answer1RadioButtonlist => Container[1].FindElements(By.CssSelector("div[class='docssharedWizToggleLabeledContent']"));
        public IWebElement Question2 => Driver.FindElement(By.CssSelector("div[id='i17']"));
        public IList<IWebElement> Answer2RadioButtonlist => Container[2].FindElements(By.CssSelector("div[class='docssharedWizToggleLabeledContent']"));

        public void scrolldown(IWebElement locator)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", locator);

        }


    }
}
