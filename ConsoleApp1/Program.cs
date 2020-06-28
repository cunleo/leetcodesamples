using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {4, 14, 15, 16, 17, 18, 19 };
            int[] resultArray = TwoSum(myArray, 8);
            Console.WriteLine("["+ resultArray[0]+","+ resultArray[1]+"]");
            Console.WriteLine("[{0},{1}]" ,resultArray[0],resultArray[1]);

            var named = (first: "Wole", second : "olapoju");
            Console.WriteLine(named.first);

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            bool foundOne = false;
            int[] thenewarray=new int [2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int result = nums[i] + nums[j];
                    if (result == target)
                    {
                        if (i != j)
                        {
                            //TODO: to get the values
                            //thenewarray[0] = nums[i];
                            //thenewarray[1] = nums[j];
                            //TODO: to get the index
                            thenewarray[0] = i;
                            thenewarray[1] = j;
                            foundOne = true;
                            break;
                        }
                    };
                    if (foundOne) break;
                }
                if (foundOne) break;
            }
            return thenewarray;
        }

     }
}
