﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_static_Extention.Helpers.Extensions
{
    internal static class MathExtensions
    {
        public static int SumOfNums(this int num1, int num2 )
        {
            return num1 + num2 ; 
        } 


        public static double PowerOfNums(this int a, int pow )
        {
            return Math.Pow(a, pow);
        }



    }
}
