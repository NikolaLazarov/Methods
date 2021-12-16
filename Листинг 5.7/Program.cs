using System;
using static System.Console;

namespace Листинг_5._7
{
    class Program
    {
        static int getMin(int[]nums,out int index){
            index = 0;
            for(int k = 1;k<nums.Length;k++){
                if(nums[k]<nums[index]){
                    index = k;
                }
            }
            return nums[index];
        }
        static void Main(string[] args)
        {
            int[] A = {24,10,7,18,34,8,12,90};
            foreach(int v in A){
                Write("| {0} ",v);
            }
            WriteLine("|");

            int val,k;
            val=getMin(A,out k);
            WriteLine("Най-малката стойност : " + val);
            WriteLine("Индекс на елемента : "+k);
            WriteLine("Проверка : A[{0}]={1}",k,A[k]);

            
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
