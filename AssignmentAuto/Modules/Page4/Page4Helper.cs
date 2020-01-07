using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AssignmentAuto.Modules.Common;
using AssignmentAuto.DataHandler;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Interactions;
using AssignmentAuto.Configuration;

namespace AssignmentAuto.Modules.Page4
{
  public class Page4Helper
    {
        private readonly Page4PageObjects _Page4PageObjects = new Page4PageObjects();
        private static readonly DataProvider DP = new DataProvider();
        readonly static string Path = CommonHelper.CSVPath();
        Actions actions = new Actions(Base.driver);

        public Page4Helper(IWebDriver driver)
        {
         _Page4PageObjects.Driver = driver;

        }

        public  void Question1()
        {
            IWebElement Question1 = _Page4PageObjects.Question1;
            string Question1Text = Question1.Text;
            string Ans1 = DP.AddMaterial(Path, Question1Text);
            _Page4PageObjects.Question1DropDown.Click();
            Thread.Sleep(3000);
            IList<IWebElement> DropDownList = _Page4PageObjects.Q1DropDownlist;
            for (int i=0;i<= DropDownList.Count; i++)
            {
                string Answer1 = DropDownList[i].Text;
                if (Answer1.Contains(Ans1))
                {
                    DropDownList[i].Click();
                    break;
                }
            }


        }

        public void Question2()
        {
            IWebElement Question2 = _Page4PageObjects.Question2;
            string Question2Text = Question2.Text;
            string Ans2 = DP.AddMaterial(Path, Question2Text);
            _Page4PageObjects.Question2DropDown.Click();
            Thread.Sleep(3000);
            IList<IWebElement> DropDownList = _Page4PageObjects.Q2DropDownlist;
            for (int i = 0; i <= DropDownList.Count; i++)
            {
                string Answer2 = DropDownList[i].Text;
                if (Answer2.Contains(Ans2))
                {
                    
                    IWebElement A = DropDownList[i];
                    _Page4PageObjects.scrolldown(A);
                    actions.MoveToElement(A).Click();
                    A.Click();
                    Thread.Sleep(2000);
                    break;
                }
            }


        }
    }
}
