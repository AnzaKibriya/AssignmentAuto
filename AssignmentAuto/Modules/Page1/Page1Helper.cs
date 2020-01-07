using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page1
{
    class Page1Helper
    {
        #region Fields
        private readonly Page1PageObjects _Page1PageObjects = new Page1PageObjects();
        #endregion
        public Page1Helper(IWebDriver driver)
        {
            _Page1PageObjects.Driver = driver;
        }

        public void FillPage1()
        {
            IWebElement Phone = _Page1PageObjects.Phone;
            string check = Phone.GetAttribute("aria-label");
            Phone.SendKeys("03157896354");
            IWebElement Name = _Page1PageObjects.Name;
            Name.SendKeys("asd");
            IWebElement Email = _Page1PageObjects.Email;
            Email.SendKeys("A@gmail.com");
            IWebElement ID = _Page1PageObjects.ID;
            ID.SendKeys("3520271670653");
            IWebElement Btn = _Page1PageObjects.btn;
            Btn.Click();




        }
       
    }
}
