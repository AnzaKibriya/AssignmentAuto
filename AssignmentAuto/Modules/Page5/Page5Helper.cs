using AssignmentAuto.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page5
{
    class Page5Helper
    {
        private readonly Page5PageObjects _Page5PageObjects = new Page5PageObjects();
        IWebDriver driver = Base.driver;
        public Page5Helper(IWebDriver driver)
        {
            _Page5PageObjects.Driver = driver;

        }
        public void Question1()
        {
            IWebElement Q1 = _Page5PageObjects.Question1;
            _Page5PageObjects.Question1UploadFile.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(1);
            Thread.Sleep(2000);
            _Page5PageObjects.driveadd.Click();
            Thread.Sleep(2000);
            _Page5PageObjects.SelectFile.Click();
            _Page5PageObjects.SelectBtn.Click();
            driver.SwitchTo().ParentFrame();
      
        }

        public void Question2()
        {
            IWebElement Q2 = _Page5PageObjects.Question2;
            _Page5PageObjects.Question2UploadFile.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(3);
            Thread.Sleep(2000);
            _Page5PageObjects.driveadd.Click();
            Thread.Sleep(2000);
            _Page5PageObjects.SelectFile.Click();
            _Page5PageObjects.SelectBtn.Click();
            driver.SwitchTo().ParentFrame();
            Thread.Sleep(5000);
        }

    }
}
