using AssignmentAuto.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Login
{
      public   class LoginHelper :Base 
    {
        private readonly LoginPageObjects _loginpageobjects = new LoginPageObjects();
        private static readonly string ID = ConfigurationManager.AppSettings.Get("ID");
        private static readonly string Password = ConfigurationManager.AppSettings.Get("Password");

        public LoginHelper(IWebDriver driver)
        {
            _loginpageobjects.Driver = driver;
        }

        #region Method
        public void Login()
        {
            IWebElement LoginField = _loginpageobjects.GetLoginField;
            LoginField.SendKeys(ID);
            Thread.Sleep(2000);
            IWebElement NextBtn = _loginpageobjects.GetNextButton;
            NextBtn.Click();
            Thread.Sleep(2000);
            IWebElement PasswordField = _loginpageobjects.GetPasswordField;
            PasswordField.SendKeys(Password);
            Thread.Sleep(2000);
            IWebElement NextBtn2 = _loginpageobjects.GetNextButton;
            NextBtn2.Click();
            Thread.Sleep(2000);

        }
        #endregion
    }
}
