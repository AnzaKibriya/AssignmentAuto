using System;
using AssignmentAuto.Configuration;
using AssignmentAuto.Modules;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace AssignmentAuto
{
    [TestFixture]
    public class Tests : Base
    {
        [Test]
        public void TestMethod1()
        {
            ExtentTest = ExtentReports.CreateTest("Automation Assessment");
            ExtentTest.Log(Status.Info, "Login");
            PageHandler.loginHelper().Login();
            ExtentTest.Log(Status.Info, "Filling Page 1");
            PageHandler.page1Helper().FillPage1();
            ExtentTest.Log(Status.Info, "Filling Page 2--Question1");
            PageHandler.page2Helper().Question1();
            ExtentTest.Log(Status.Info, "Filling Page 2--Question2");
            PageHandler.page2Helper().Question2();
            ExtentTest.Log(Status.Info, "Filling Page 2--Clicking Next Button");
            PageHandler.commonHelper().ClickNextBtn();
            ExtentTest.Log(Status.Info, "Filling Page 3--Question1");
            PageHandler.page3Helper().Question1();
            ExtentTest.Log(Status.Info, "Filling Page 3--Question2");
            PageHandler.page3Helper().Question2();
            ExtentTest.Log(Status.Info, "Filling Page 3--Clicking Next Button");
            PageHandler.commonHelper().ClickNextBtn();
            ExtentTest.Log(Status.Info, "Filling Page 4--Question1");
            PageHandler.page4Helper().Question1();
            ExtentTest.Log(Status.Info, "Filling Page 4--Question2");
            PageHandler.page4Helper().Question2();
            ExtentTest.Log(Status.Info, "Filling Page 4--Clicking Next Button");
            PageHandler.commonHelper().ClickNextBtn();
            ExtentTest.Log(Status.Info, "Filling Page 5--Question1");
            PageHandler.page5Helper().Question1();
            ExtentTest.Log(Status.Info, "Filling Page 5--Question2");
            PageHandler.page5Helper().Question2();
            PageHandler.commonHelper().ClickNextBtn();
        }
    }
}
