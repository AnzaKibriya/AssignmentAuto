using AssignmentAuto.Configuration;
using AssignmentAuto.Modules.Common;
using AssignmentAuto.Modules.Login;
using AssignmentAuto.Modules.Page1;
using AssignmentAuto.Modules.Page2;
using AssignmentAuto.Modules.Page3;
using AssignmentAuto.Modules.Page4;
using AssignmentAuto.Modules.Page5;
using AssignmentAuto.Modules.Page6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.Modules
{
    class PageHandler
    {
        private static readonly LoginHelper loginHelperInstance = new LoginHelper(Base.driver);
        private static readonly Page1Helper page1HelperInstance = new Page1Helper(Base.driver);
        private static readonly Page2Helper page2HelperInstance = new Page2Helper(Base.driver);
        private static readonly Page3Helper page3HelperInstance = new Page3Helper(Base.driver);
        private static readonly Page4Helper page4HelperInstance = new Page4Helper(Base.driver);
        private static readonly Page5Helper page5HelperInstance = new Page5Helper(Base.driver);
        private static readonly Page6Helper page6HelperInstance = new Page6Helper(Base.driver);
        private static readonly CommonHelper commonHelperInstance = new CommonHelper(Base.driver);

        public static LoginHelper loginHelper()
        {
            return loginHelperInstance;
        }
        public static Page1Helper page1Helper()
        {
            return page1HelperInstance;
        }
        public static Page2Helper page2Helper()
        {
            return page2HelperInstance;
        }
        public static Page3Helper page3Helper()
        {
            return page3HelperInstance;
        }
        public static Page4Helper page4Helper()
        {
            return page4HelperInstance;
        }
        public static Page5Helper page5Helper()
        {
            return page5HelperInstance;
        }
        public static Page6Helper page6Helper()
        {
            return page6HelperInstance;
        }
        public static CommonHelper commonHelper()
        {
            return commonHelperInstance;
        }


    }
}
