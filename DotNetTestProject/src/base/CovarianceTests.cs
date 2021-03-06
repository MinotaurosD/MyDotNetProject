﻿using System;

namespace DotNetTestProject
{
    /// <summary>
    /// 协变与逆变
    /// </summary>
    public class CovarianceTests
    {
        /// <summary>
        /// 测试数组协变，将派生程度更大的类型的数组隐式转换为派生程度更小的类型的数组后，可能会出现类型不安全的操作
        /// </summary>
        public void Test1()
        {
            object[] myArray = new string[5];
            IComparable[] myOtherArray = new string[5];
            try
            {
                myArray[0] = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                myOtherArray[0] = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// 测试数组协变，将派生程度更大的类型的数组隐式转换为派生程度更小的类型的数组后，可能会出现类型不安全的操作
        /// </summary>
        public void Test2()
        {
            try
            {
                BaseClass[] baseClasses = new Class1[1];
                baseClasses[0] = new Class2();
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private class BaseClass { }
        private class Class1 : BaseClass { }
        private class Class2 : BaseClass { }
    }
}