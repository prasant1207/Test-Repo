using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClass;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string>();
            Helper helperLib=new Helper();

            for (int i = 0; i < 100; i++)
            {
                testList.Add("item" + i.ToString());
            }

            string csv = helperLib.ListToCSV(testList);
            int length = csv.Split(',').Length;

            List<string> testList2 = helperLib.CSVToList(csv);

            //Sum of Integer List

            List<int> integerList = new List<int>();
            for (int i = 0; i < length; i++)
            {
                integerList.Add(i);
            }

            long TotalSum = helperLib.SumOfIntList(integerList);
        }
    }
}
