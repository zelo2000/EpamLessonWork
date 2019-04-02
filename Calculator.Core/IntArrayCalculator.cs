using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class IntArrayCalculator : ICalculator<int[]>
    {
        /// <summary>
        /// Get element by element division
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>Element by element division</returns>
        public int[] Div(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            try
            {
                if (a.Length > b.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        result.Add(a[i] / b[i]);
                    }
                    for (int i = b.Length; i < a.Length; i++)
                    {
                        result.Add(a[i] / 1);
                    }
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] / b[i]);
                    }
                    for (int i = a.Length; i < b.Length; i++)
                    {
                        result.Add(1 / b[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] / b[i]);
                    }
                }
                return result.ToArray();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("An element of the second array is 0", e);
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("One of the operands is null", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new IndexOutOfRangeException("Index out of range", e);
            }
        }
        /// <summary>
        /// Get element by element multiplication
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>Element by element multiplication</returns>
        public int[] Mul(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            try
            {
                if (a.Length > b.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        result.Add(a[i] * b[i]);
                    }
                    for (int i = b.Length; i < a.Length; i++)
                    {
                        result.Add(1 * a[i]);
                    }
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] * b[i]);
                    }
                    for (int i = a.Length; i < b.Length; i++)
                    {
                        result.Add(1 * b[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] * b[i]);
                    }
                }
                return result.ToArray();
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("One of the operands is nullk", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new IndexOutOfRangeException("Index out of range", e);
            }
        }
        /// <summary>
        /// Get element by element subtraction
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>Element by element subtraction</returns>
        public int[] Sub(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            try
            {
                if (a.Length > b.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        result.Add(a[i] - b[i]);
                    }
                    for (int i = b.Length; i < a.Length; i++)
                    {
                        result.Add(a[i]);
                    }
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] - b[i]);
                    }
                    for (int i = a.Length; i < b.Length; i++)
                    {
                        result.Add(-b[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] - b[i]);
                    }
                }
                return result.ToArray();
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("One of the operands is null", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new IndexOutOfRangeException("Index out of range", e);
            }
        }
        /// <summary>
        /// Get element by element addition
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <returns>Element by element addition</returns>
        public int[] Sum(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            try
            {
                if (a.Length > b.Length)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        result.Add(a[i] + b[i]);
                    }
                    for (int i = b.Length; i < a.Length; i++)
                    {
                        result.Add(a[i]);
                    }
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] + b[i]);
                    }
                    for (int i = a.Length; i < b.Length; i++)
                    {
                        result.Add(b[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        result.Add(a[i] + b[i]);
                    }
                }
                return result.ToArray();
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException("One of the operands is null", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new IndexOutOfRangeException("Index out of range", e);
            }
        }
    }
}
