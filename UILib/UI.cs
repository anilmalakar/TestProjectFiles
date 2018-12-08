using BizLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILib
{
    public class UI
    {
        /// <summary>
        /// UI
        /// </summary>
        IBizData _bizData;
        public UI(IBizData bizData)
        {
            _bizData = bizData;
        }

        public string GetData()
        {
            return _bizData.GetData();
        }

        public void SetData(string data)
        {
            _bizData.SetData(data);
        }
    }
}
