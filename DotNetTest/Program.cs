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

        static void Main(string[] args)
        {
            new CSharpNewFeatures().CheckNewFeatures();

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            }
            OnLineTests.HackerRankTests h = new OnLineTests.HackerRankTests();
            int res = h.findMaxSum(arr); Console.WriteLine(res);

            //int n = Int32.Parse(Console.ReadLine());
            //Dictionary<String, int> dict = new Dictionary<String, int>();

            //for (int j = 0; j < n; j++)
            //{
            //    string[] sTemp = Console.ReadLine().Split(' ');
            //    dict.Add(sTemp[0], Int32.Parse(sTemp[1]));
            //}

            //// perform queries
            //string queryKey;
            //while ((queryKey = Console.ReadLine()) != null)
            //{
            //               }

           //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            // OnLineTests.ReArrangeGetLargestNumber.GetLargetNumberOld(54572);
            //int res = OnLineTests.FindMaxPossibleInt.MaxPossible(268);
            //int res3 = OnLineTests.FindMaxPossibleInt.MaxPossible(-999);
            //for (int i = 1; i <= 100; i++)
            //{
            //    int res22 = OnLineTests.FindingPatternInSequence.getBinaryPeriodForIntAsinCodility(i);
            //    if (res22 == -1)
            //        Console.WriteLine(res22);
            //}

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
