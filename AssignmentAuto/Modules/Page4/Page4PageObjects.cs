using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentAuto.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AssignmentAuto.Modules.Page4
{
   public class Page4PageObjects
    {
        public IWebDriver Driver;
        Actions actions = new Actions(Base.driver);
        public  IWebElement Question1 => Driver.FindElement(By.CssSelector("div[id='i1']"));
        public  IWebElement Question2 => Driver.FindElement(By.CssSelector("div[id='i5']"));
        public  IWebElement Q1d => Driver.FindElement(By.XPath("//*[@id='mG61Hd']/div/div/div[2]/div[2]/div/div[2]/div[1]/div[1]/div[1]/span"));
        public IList<IWebElement> QuestionContainer => Driver.FindElements(By.ClassName("freebirdFormviewerViewNumberedItemContainer"));
        public  IWebElement Question1Div => QuestionContainer[1];
        public   IWebElement Question2Div => QuestionContainer[2];
        public IWebElement Question1DropDown => Question1Div.FindElement(By.CssSelector("div[class='quantumWizMenuPaperselectOptionList']"));
        public   IWebElement Dropdowndiv => Question1Div.FindElement(By.CssSelector("div[jsname='V68bde']"));
        public  IList<IWebElement> Q1DropDownlist => Dropdowndiv.FindElements(By.CssSelector("div[jsname='wQNmvb']"));
        public  IWebElement Question2DropDown => Question2Div.FindElement(By.CssSelector("div[class='quantumWizMenuPaperselectOptionList']"));
        public  IWebElement Dropdowndiv2 => Question2Div.FindElement(By.CssSelector("div[jsname='V68bde']"));
        public  IList<IWebElement> Q2DropDownlist => Dropdowndiv2.FindElements(By.CssSelector("div[jsname='wQNmvb']"));
        public void scrolldown(IWebElement locator)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", locator);

        }



    }
}
