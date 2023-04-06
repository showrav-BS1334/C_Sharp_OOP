using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.Problem18
{
    internal class Problem18
    {
        public void Solve()
        {
            // call from class
            GovtInfo.PrintNotice();

            // call from object
            BSInfo bsInfo = new BSInfo();
            bsInfo.PrintNotice();
        }
    }
}
