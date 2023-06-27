using ContainsDuplicate;

namespace Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Case 1
            int[] input1 = { 1, 2, 3, 1};
            var output1 = Solution.ContainsDuplicate(input1);

            Console.WriteLine($"Output: {output1}");

            //Case 2
            int[] input2 = { 1, 2, 3, 4 };
            var output2 = Solution.ContainsDuplicate(input2);

            Console.WriteLine($"Output: {output2}");

            //Case 3
            int[] input3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var output3 = Solution.ContainsDuplicate(input3);

            Console.WriteLine($"Output: {output3}");
        }
    }
    
}