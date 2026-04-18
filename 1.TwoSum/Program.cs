

class TwoSum
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        int target = 4;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine("Index:" + i + "," + j);
                }
            }
        }
    }
}