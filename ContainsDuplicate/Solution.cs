namespace ContainsDuplicate
{
    public static class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> NumberSet = new HashSet<int>();

            foreach (int num in nums)
            {
                if (NumberSet.Contains(num))
                
                    return true;

                    NumberSet.Add(num);
                
            }
            return false;
        }
    }
}
