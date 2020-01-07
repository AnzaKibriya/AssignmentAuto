using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentAuto.DataHandler;
using System.Configuration;
using AssignmentAuto.Modules.Common;

namespace AssignmentAuto.Modules.Page2
{
    class Page2Helper
    {
        #region Fields
        private readonly Page2PageObjects _Page2PageObjects = new Page2PageObjects();
        private static readonly DataProvider DP = new DataProvider();
        readonly string Path = CommonHelper.CSVPath();
        #endregion
        public Page2Helper(IWebDriver driver)
        {
            _Page2PageObjects.Driver = driver;
        }
        public void Question1()
        {
            IWebElement Question1Element = _Page2PageObjects.Question1;
            string Question1 = Question1Element.Text;
            string Ans1=  DP.AddMaterial(Path, Question1);
            IList<IWebElement> AnswerList = _Page2PageObjects.Answer1RadioButtonlist;
            for (int i =0; i<= AnswerList.Count; i++)
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
            IWebElement Question2Element = _Page2PageObjects.Question2;
            string Question2 = Question2Element.Text;
            string Ans2 = DP.AddMaterial(Path, Question2);
            IList<IWebElement> AnswerList = _Page2PageObjects.Answer2RadioButtonlist;
            for (int i = 0; i <= AnswerList.Count; i++)
            {
                string Answer2 = AnswerList[i].Text;
                if (Answer2.Contains(Ans2))
                {
                    IWebElement A = AnswerList[i];
                    _Page2PageObjects.scrolldown(A);
                    AnswerList[i].Click();
                    break;
                }
            }
        }
         
    }
}
