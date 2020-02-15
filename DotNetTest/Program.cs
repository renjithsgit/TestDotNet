using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class Program
    {
       
        static  int solution1(int N)
        {

            //// write your code in C# 6.0 with .NET 4.5 (Mono)
            //int insertingDigit = 5;
            //int flag = N >= 0 ? 1 : -1;
            ////N = Math.Abs(N);
            //int maxValue = 0;

            //int result = 0;
            //List<int> inDigits = GetDigits(N);
            //int multiplier = 1;
            //if (inDigits.Count() == 0) inDigits.Add(0);
            //if (N >= 0)
            //{
            //    for (int i = 0; i <= inDigits.Count(); i++)
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        for (int j = 0; j < inDigits.Count(); j++)
            //        {
            //            if (i == j) sb.Append(insertingDigit.ToString());
            //            sb.Append(inDigits[j].ToString());
            //        }

            //        if (i == inDigits.Count()) sb.Append(insertingDigit.ToString());
            //        result = Int32.Parse(sb.ToString());
            //        if (result > maxValue) maxValue = result;
            //    }
            //}

            //return maxValue;
            // write your code here
            StringBuilder sb = new StringBuilder(Math.Abs(N).ToString());
            int flag = N >= 0 ? 1 : -1;
            if (N >= 0)
            {
                int idx = 0;
                while (idx < sb.Length && (Int32.Parse(sb[idx].ToString()) - 0) >= 5)
                {
                    idx++;
                }
                sb.Append(5);
            }
            else
            {
                int idx = 0;
                while (idx < sb.Length && (Int32.Parse(sb[idx].ToString()) - 0) <= 5)
                    idx++;
                sb.Append(5);
            }
            int val = Int32.Parse(sb.ToString());
            return flag * val;
        }
       
        static int MaximumPossible(int num)
        {
            // digit to insert in given number
            int digit = 5;

            // edge case
            if (num == 0)
            {
                return digit * 10;
            }

            // -1 if num is negative number else 1
            int negative = num / Math.Abs(num);
            // get the absolute value of given number
            num = Math.Abs(num);
            int n = num;
            // maximum number obtained after inserting digit.
            int maxVal = int.MinValue;
            int counter = 0;
            int position = 1;

            // count the number of digits in the given number.
            while (n > 0)
            {
                counter++;
                n = n / 10;
            }

            // loop to place digit at every possible position in the number,
            // and check the obtained value.
            for (int i = 0; i <= counter; i++)
            {
                int newVal = ((num / position) * (position * 10)) + (digit * position) + (num % position);

                // if new value is greater the maxVal
                if (newVal * negative > maxVal)
                {
                    maxVal = newVal * negative;
                }

                position = position * 10;
            }

            return maxVal;
        }

        static void Main(string[] args)
        {
            //int res = solution1(268);
            //int res1 = solution1(670);
            //int res2 = solution1(0);
            //int res3 = solution1(-999);
            int res22 = getBinaryPeriodForIntAsinCodility(955);
            Console.WriteLine(res22);

            //DelegateTest d = new DelegateTest();
            //d.DoAsyncOperation();

            //new StackHeapTest().GoValueType();

            //int[] A = Enumerable.Range(1, 100000).ToArray();
            //DateTime start = DateTime.Now;
            //SmallestPositive s = new SmallestPositive();
            //int res= s.solution(A);
            //TimeSpan timeDiff = DateTime.Now - start;
            //double diff= timeDiff.TotalMilliseconds;
            //Console.WriteLine(res+ "  " + diff);

            //start = DateTime.Now;
            //int res = s.solution2(A);
            //TimeSpan timeDiff = DateTime.Now - start;
            //double diff = timeDiff.TotalMilliseconds;
            //Console.WriteLine(res + "  " + diff);
            Console.WriteLine("Finished");
            //string[] countries = { "Denmark", "Sweden", "Norway" };

            //var res = countries.FirstOrDefault(x => x == "hh");
            //Console.WriteLine(res);
            //string s = "(?]["; //expected 1
            //int r  = fillMissingBrackets(s);
            //s = "(((?"; //expecetd 0
            //r = fillMissingBrackets(s);
            //s = "((([]?"; //expecetd 0
            //r = fillMissingBrackets(s);
            //s = "((([]?"; //expecetd 0
            //r = fillMissingBrackets(s);
            //s= "(((?'
            //r = fillMissingBrackets(s);

            ////Reflection to get and set the private properties
            //PublicAccessVerify test = new PublicAccessVerify();
            //var privateInt = test.GetType().GetProperty("privateInt", BindingFlags.Instance | BindingFlags.NonPublic);

            //int value = (int)privateInt.GetValue(test);
            //privateInt.SetValue(test, 45); // Set the property.
            //value = (int)privateInt.GetValue(test);

            ////immediate and deffered
            //LyncConversion lc = new LyncConversion();
            //lc.TestDefferedAndImmediateExecution();

            //valid code check
            // ValidCodeCheck.ExceptionWithMessage();


            //TestEventHandler ts = new TestEventHandler();
            //ts.TestHandler();

            //LamdaConversion l = new LamdaConversion();
            //l.PrintAsRequiredLamda();
            //ReverseProgram r = new ReverseProgram();
            ////r.IsPalindrome("malayalam");
            ////r.IsPalindrome("Malayalam");
            ////r.IsPalindrome("abcddb");
            //int[] arr = { 0, 1, 2, 3, 4 };
            //r.ReverseGeneric(arr);
            //string[] s1 = { "a", "b", "c", "d" };
            //r.ReverseGeneric(s1);

            //string s = "test";
            //s = s.SampleExtensionString("ReturnSample");
            //Console.WriteLine(s);
            Console.ReadLine();
        }

        public static int fillMissingBrackets(string s)
        {
            List<char> LstC1 = new List<char>();
            int noOfSplits = 0;
            int s1Open = 0;
            int s1Close = 0;
            bool s1Opposite = false;
            int s1 = 0;

            int c1Open = 0;
            int c1Close = 0;
            int c1 = 0;
            bool c1Opposite = false;
            int noOfC1Occurences = 0;

            int q1 = 0;
            foreach (char ch in s.ToCharArray())
            {
                if ((ch == '(') || (ch == ')'))
                {
                    if (ch == '(')
                    {
                        if (LstC1.Contains(')'))
                        {
                            c1--;
                        }
                        else
                            c1++;

                        //if (noOfS1Occurences == 0)
                        //    c1Open++;
                        //else if (noOfS1Occurences > 0)
                        //    noOfC1Occurences++;
                    }
                    else if (ch == ')')
                    {
                        if (LstC1.Contains('('))
                        {
                            c1Opposite = true;
                            c1--;
                        }
                        else
                            c1++;
                    }

                }
                else if ((ch == '[') || (ch == ']'))
                {
                    if (ch == '[')
                    {
                        if (LstC1.Contains(']'))
                        {
                            s1--;
                        }
                        else
                            s1++;

                    }
                    else if (ch == ']')
                    {
                        if (LstC1.Contains('['))
                        {
                            s1--;
                            s1Opposite = true;
                        }
                        else
                            s1++;
                    }

                }
                else if (ch == '?')
                    { q1++; }
                LstC1.Add(ch);

                if (c1 > q1 || s1 > q1) noOfSplits = 0;
                else if (isSplitOk(c1 + s1 + q1))
                    noOfSplits++;

            }
            if (noOfSplits > 0) noOfSplits--;

            return noOfSplits;
        }

        public static bool isSplitOk(int sumTotal)
        {
            return (sumTotal % 2) == 0;
        }
    }
}
