using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page6
{
    class Page6PageObjects
    {
        public IWebDriver Driver;
        public IList<IWebElement> QuestionContainer => Driver.FindElements(By.ClassName("freebirdFormviewerViewNumberedItemContainer"));
        public IWebElement Question1 => QuestionContainer[1].FindElement(By.CssSelector("div[class='freebirdFormviewerViewItemsItemItemTitleContainer']"));
        public IWebElement CurrentDateDiv => QuestionContainer[1].FindElement(By.CssSelector("div[class='quantumWizTextinputPaperinputInputArea']"));
        public IWebElement Inputdate => CurrentDateDiv.FindElement(By.CssSelector("input[jsname='YPqjbf']"));
        public IWebElement Question2 => QuestionContainer[2].FindElement(By.CssSelector("div[class='freebirdFormviewerViewItemsItemItemTitleContainer']"));
      
    }
}
