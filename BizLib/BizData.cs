using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLib
{
    public class BizData : IBizData
    {
        string dataStored = null;
        public string GetData()
        {
            return dataStored ?? "No Data Stored";
        }

        public void SetData(string data)
        {
            dataStored = data;
        }
    }
}
