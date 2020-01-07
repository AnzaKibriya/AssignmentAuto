using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Common
{
    class CommonHelper
    {

        CommonPageObjects _CommonPageObjects = new CommonPageObjects();
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        private IWebDriver driver;
        public static readonly string FilePath = ConfigurationManager.AppSettings.Get("FilePath");

        public CommonHelper(IWebDriver driver)
        {
            _CommonPageObjects.Driver = driver;
        }

        public void ClickNextBtn()
        {
            Thread.Sleep(2000);
            _CommonPageObjects.NextBtn.Click();
           
        }
        public  static string CSVPath()
        {

            string Path = BasePath + FilePath;
            return Path;
        }
       

    }

}
   


