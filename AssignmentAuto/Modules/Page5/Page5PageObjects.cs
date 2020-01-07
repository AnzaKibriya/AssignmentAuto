using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page5
{
    class Page5PageObjects
    {
        public IWebDriver Driver;
        public IWebElement Question1 => Driver.FindElement(By.CssSelector("div[id='i1']"));
        public IWebElement Question2 => Driver.FindElement(By.CssSelector("div[id='i5']"));
        public IList<IWebElement> QuestionContainer => Driver.FindElements(By.ClassName("freebirdFormviewerViewNumberedItemContainer"));
        public IWebElement Question1UploadFile => QuestionContainer[1].FindElement(By.CssSelector("div[jscontroller='VXdfxd']"));
        public IWebElement Question2UploadFile => QuestionContainer[2].FindElement(By.CssSelector("div[jscontroller='VXdfxd']"));

        public IWebElement btn => Driver.FindElement(By.XPath("//*[@id='mG61Hd']/div/div[2]/div[2]/div[2]/div/div[3]/span/span"));
      
        public IWebElement driveadd => Driver.FindElement(By.XPath("//*[@id=':6']/div"));
        
        public IWebElement SelectFile => Driver.FindElement(By.CssSelector("div[class='fe-Hh-eg-O-Uh-Vh']"));
        public IWebElement SelectBtn => Driver.FindElement(By.Id("picker:ap:2"));
        
    }
}
