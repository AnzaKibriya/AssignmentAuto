using AssignmentAuto.DataHandler;
using AssignmentAuto.Modules.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page3
{
    class Page3Helper
    {
        #region Fields
        private readonly Page3PageObjects _Page3PageObjects = new Page3PageObjects();
        private static readonly DataProvider DP = new DataProvider();
        readonly string Path = CommonHelper.CSVPath();
        #endregion

        public Page3Helper(IWebDriver driver)
        {
            _Page3PageObjects.Driver = driver;
        }
        public void Question1()
        {
            IWebElement Question1 = _Page3PageObjects.Question1;
            string Question1Text = Question1.Text;
            string Ans1 = DP.AddMaterial(Path, Question1Text);
            IList<IWebElement> AnswerList = _Page3PageObjects.Answer1List;
            for (int i = 0; i <= AnswerList.Count; i++)
            {
                string Answer1 = AnswerList[i].Text;
                if (Answer1.Contains(Ans1))
                {
                    AnswerList[i].Click();
                    break;
                }
            }

        }
        public void Question2()
        {
            IWebElement Question2 = _Page3PageObjects.Question2;
            String Question2Text = Question2.Text;
            string Ans2 = DP.AddMaterial(Path, Question2Text);
            IList<IWebElement> AnswerList = _Page3PageObjects.Answer2List;
            for (int i = 0; i <= AnswerList.Count; i++)
            {
                string Answer1 = AnswerList[i].Text;
                if (Answer1.Contains(Ans2))
                {
                    IWebElement A = AnswerList[i];
                    _Page3PageObjects.scrolldown(A);
                    AnswerList[i].Click();
                    break;
                }
            }
        }
    }

}
