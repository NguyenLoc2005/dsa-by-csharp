using System;
using System.Linq;

class MedianOfTwoSortedArrays
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        int[] merge = nums1.Concat(nums2).ToArray();
        float median = 0;

        Console.WriteLine(string.Join(", ", merge));

        for(int i = 0; i < merge.Length; i++)
        {
            for(int j = i + 1; j < merge.Length; j++)
            {
                if(merge[i] > merge[j])
                {
                    int temp = merge[i];
                    merge[i] = merge[j];
                    merge[j] = temp;
                }
            }
        }
        if (merge.Length % 2 != 0)
        {
            median = merge[(merge.Length/2)];
        }
        else
        {
            median = (float) (merge[(merge.Length / 2)]+ merge[(merge.Length / 2) -1]) / 2;
        }

        
        Console.WriteLine(string.Join(", ", merge));
        Console.WriteLine(median);

        Console.ReadLine();

    }
}