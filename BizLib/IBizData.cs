using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLib
{
    public interface IBizData
    {
        string GetData();
        void SetData(string data);
    }
}
