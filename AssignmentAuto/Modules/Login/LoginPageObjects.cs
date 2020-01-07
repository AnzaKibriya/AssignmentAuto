using AssignmentAuto.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Login
{
     public  class LoginPageObjects 

    {
        public IWebDriver Driver;

        #region Properties
        public IWebElement GetLoginField => Driver.FindElement(By.CssSelector("input[id='identifierId']"));
        public IWebElement GetNextButton => Driver.FindElement(By.CssSelector("span[class='CwaK9']"));
        public IWebElement GetPasswordField => Driver.FindElement(By.CssSelector("input[name='password']"));
        
        #endregion


    }
}
