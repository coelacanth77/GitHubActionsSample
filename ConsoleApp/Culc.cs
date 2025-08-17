using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Culc
    {
        /// <summary>
        /// 二つの整数を加算します。
        /// </summary>
        /// <param name="a">第一引数の整数</param>
        /// <param name="b">第二引数の整数</param>
        /// <returns>二つの整数の合計</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 二つの整数を減算します。
        /// </summary>
        /// <param name="a">被減数となる整数</param>
        /// <param name="b">減数となる整数</param>
        /// <returns>二つの整数の差</returns>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// 二つの整数を乗算します。
        /// </summary>
        /// <param name="a">第一引数の整数</param>
        /// <param name="b">第二引数の整数</param>
        /// <returns>二つの整数の積</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// 二つの整数を除算します。
        /// </summary>
        /// <param name="a">被除数となる整数</param>
        /// <param name="b">除数となる整数</param>
        /// <returns>二つの整数の商（double型）</returns>
        /// <exception cref="DivideByZeroException">除数が0の場合にスローされます</exception>
        public static double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }
    }
}
