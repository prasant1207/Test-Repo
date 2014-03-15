using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperClass
{
    public class Helper
    {
        public string Author()
        {
            return "Prashant Tiwari";
        }
        public string ListToCSV(List<string> listToConvert)
        {
            string returnString = "";
            foreach (string item in listToConvert)
            {
                returnString = returnString + item + ",";
            }

            return returnString.Substring(0, returnString.Length - 1);
        }
        public List<string> CSVToList(string strCSV)
        {
            List<string> returnList = new List<string>();
            string[] strSplit = strCSV.Split(',');
            for (int i = 0; i < strSplit.Length; i++)
            {
                returnList.Add(strSplit[i]);
            }
            return returnList;
        }

        public int SumOfIntList(List<int> listToCount)
        {
            int totalSum = 0;
            foreach (int item in listToCount)
            {
                totalSum = totalSum +item;
            }

            return totalSum;
        }
    }
}
