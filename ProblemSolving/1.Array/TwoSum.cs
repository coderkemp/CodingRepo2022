public class TwoSum {
    public int[] TwoSums(int[] nums, int target) 
    {
        int sum=0;
        List<int> result = new List<int>();
        for(int i=0;i<nums.Length-1;i++)
        {
            for(int j=i+1;j<nums.Length-1;j++)
            {
                if((nums[i]+nums[j])==target)
                {
                    result.Add(i);
                    result.Add(j);
                }
            }
        }    
        return result.ToArray();
    }

    public static void main(string[] args)
    {
        TwoSum ts = new TwoSum();
        int[] test = {2,7,11,15};
        System.Console.WriteLine(ts.TwoSums(test,9));
    }
}