using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page1
{
    class Page1PageObjects
    {
        public IWebDriver Driver;

        public IWebElement Phone => Driver.FindElement(By.Name("entry.1110907389"));
        public IWebElement Name => Driver.FindElement(By.Name("entry.1449005772"));
        public IWebElement Email => Driver.FindElement(By.Name("entry.1685270148"));
        public IWebElement ID => Driver.FindElement(By.Name("entry.364594827"));
        public IWebElement NextBtn => Driver.FindElement(By.Name("entry.364594827"));
        public IWebElement btn => Driver.FindElement(By.CssSelector("span[class='quantumWizButtonPaperbuttonContent']"));
    }
}
