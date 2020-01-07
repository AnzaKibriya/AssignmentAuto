using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules.Page6
{
    class Page6Helper
    {
        private readonly Page6PageObjects _Page5PageObjects = new Page6PageObjects();
        DateTime now = DateTime.Now;
        public string[] words = null;
        string date;
        string Time;
        string Format;
        public Page6Helper(IWebDriver driver)
        {
            _Page5PageObjects.Driver = driver;

        }
        public void GetDateTime()
        {
            string S = now.ToString();
            words = S.Split(' ');
            date = words[0];
            Time = words[1];
            Format = words[2];
        }
        public void Question1()
        {
            GetDateTime();
            string[] dateday = date.Split('/');
            string s = dateday[0];
            string s2 = dateday[1];
            string s3 = dateday[2];

        }
    }
}
