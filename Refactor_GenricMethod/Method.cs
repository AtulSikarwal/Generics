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



        public double floatMax(double FirstNum, double SecondNum, double ThirdNum)
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


      public string FindMaxString(string firstString,string secondString,string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
              firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||

               firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||

                 secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||

                 thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            return firstString;
        }


    }
}
