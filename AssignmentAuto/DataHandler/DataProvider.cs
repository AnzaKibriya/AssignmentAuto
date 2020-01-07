using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAuto.DataHandler
{
   
     public class DataProvider
    {
        public string Ans;
        public  string AddMaterial(string readFileMaterial, string tofind)
        {
            
            using (var reader = new StreamReader(readFileMaterial))
            {
                if (!reader.EndOfStream)
                {
                    reader.ReadLine();
                }

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line == null) continue;
                     Ans = ParseInventoryData(line, tofind);
                    if (Ans != null) {
                        break;
                    }
                }
                
            }
            return Ans;
        }
        public string ParseInventoryData(string inventoryDataRow, string Ques)
        {
            IList<string> data = inventoryDataRow.Split(',').Select(x => x.Trim()).ToList();

            int index = 0;
            bool found = false;
            int findIndex = -1;
            string foundValue = null;
            while (!found && index < data.Count)
            {
                string ss = data[index];
                if (Ques.Contains(ss))
                {
                    found = true;
                    findIndex = index + 1;
                    foundValue = data[findIndex];
                    break;
                }
                break;

            }

            return foundValue;

            
        }
    }
}
