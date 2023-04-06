using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.Problem14
{
    internal class TempClass
    {
        public void ChangeReferenceValue(OriginalClass original)
        {
            original.vlaue = 2;
            var temp = new OriginalClass()
            {
                vlaue = original.vlaue,
                MyProperty = new OriginalClass() { }
            };

        }



        public void changePremitiveValue(int number) 
        {
            number = 200;
        }
    }
}
