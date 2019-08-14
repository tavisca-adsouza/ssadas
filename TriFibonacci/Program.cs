using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codejam
{
    class TriFibonacci
    {
        private int sumOfLast3;

        public int Complete(int[] test)
        {
            int firstThreeTotal = test[0] + test[1] + test[2];

           for(int i=0; i<test.Length; i++)
            {
                
                try
                {
                    int sumOfLast3 = AddLast3(i, test);
                }
                catch (System.IndexOutOfRangeException e)
                {

                    int fourthNumber = test[3];
                    if (test[0] == -1 || test[1] == -1 || test[2] == -1)
                    {
                        firstThreeTotal = firstThreeTotal + 1;
                        int ans = fourthNumber - firstThreeTotal;
                        if (ans <= 0)
                            return -1;
                        if (test[0] == -1)
                            test[0] = ans;
                        else if (test[1] == -1)
                            test[1] = ans;
                        else 
                            test[2] = ans;
                        int sumOfLast3 = 0;
                    }

                }

                //int triFib = test[i];
                if (test[i] != sumOfLast3 && test[i] != -1)
                    return -1;
                if(test[i] == -1)
                {
                    sumOfLast3 = AddLast3(i, test);
                    test[i] = sumOfLast3;
                    if (test[i] <= 0)
                        return -1;
                }
            }
        }

        private int AddLast3(int index, int[] arr)
        {
            return (arr[index - 1] + arr[index - 2] + arr[index - 3]);
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
