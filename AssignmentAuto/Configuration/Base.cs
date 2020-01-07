using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Configuration
{
    [SetUpFixture]
    public class Base
    {
        #region Fields

        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string[] Path = BasePath.Split(new[] { "Debug" }, StringSplitOptions.None);
        private static readonly string DriverPath = ConfigurationManager.AppSettings.Get("ChromeDriverPath");
        public static string ChromeDriver = BasePath + DriverPath;
        private static readonly string URL = ConfigurationManager.AppSettings.Get("URL");
        public static IWebDriver driver;
        public static ExtentReports ExtentReports;
        public static ExtentTest ExtentTest;
        private readonly string _testFolderPath =
          BasePath + ConfigurationManager.AppSettings.Get("_testFolderPath");
        #endregion
        #region Methods

        [OneTimeSetUp]
        protected void InitializeTest()
        {
           
            driver = new ChromeDriver(ChromeDriver);
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad =  TimeSpan.FromSeconds(10);
            var reportPath = new ExtentHtmlReporter(_testFolderPath);
            ExtentReports = new ExtentReports();
            ExtentReports.AttachReporter(reportPath);


        }
        #endregion
    }
}

