using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAss
{
    internal class Method
    {
        public int intMax(int FirstNum,int SecondNum,int ThirdNum)
        {
            if (FirstNum.CompareTo(SecondNum) > 0 && FirstNum.CompareTo(ThirdNum) > 0)
            {
                return FirstNum;
            }
            if (SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) > 0)
            {
                return SecondNum;
            }
            if (ThirdNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(FirstNum) > 0)
            {
                return ThirdNum;
            }
            throw new Exception("firstnumber,secondnumber and thirdnumber are same");
        }


       


        
    }
}
