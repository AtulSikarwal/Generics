﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAss
{
    public  class ClassMethod<T> where T : IComparable
    {
      public T FirstNum, SecondNum, ThirdNum;
        public ClassMethod(T firstNum, T secondNum, T thirdNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
            ThirdNum = thirdNum;
        }

        public void FindMax()
        {
            if (FirstNum.CompareTo(SecondNum) > 0 && FirstNum.CompareTo(ThirdNum) > 0)
            {
                Console.WriteLine(FirstNum); 
            }
            if (SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) > 0)
            {
                Console.WriteLine(SecondNum); 
            }
            if (ThirdNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(FirstNum) > 0)
            {
                Console.WriteLine(ThirdNum) ;
            }
           
        }

    }
}
