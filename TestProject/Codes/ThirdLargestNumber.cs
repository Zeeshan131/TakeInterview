namespace TestProject.Codes;
public class ThirdLargestNumber
{
    public static void ThirdLargest(int[] nums, int l)
    {
        // // Using Bubble sort
        // for (int i = 0; i < l - 1; i++) {
        //     for (int j = 0; j < l - i - 1; j++) {
        //         if (nums[j] < nums[j + 1]) {
        //             int temp = nums[j];
        //             nums[j] = nums[j + 1];
        //             nums[j + 1] = temp;
        //         }
        //     }
        // }
        // Console.WriteLine(nums[2]);

        // using more effcient approach with pointer
        int firstLargest = int.MinValue;
        int secondLargest = int.MinValue;
        int thirdLargest = int.MinValue;

        foreach (int num in nums)
        {
            if (num > firstLargest)
            {
                thirdLargest = secondLargest;
                secondLargest = firstLargest;
                firstLargest = num;
            }
            else if (num > secondLargest)
            {
                thirdLargest = secondLargest;
                secondLargest = num;
            }
            else if (num > thirdLargest)
            {
                thirdLargest = num;
            }
        }

        if (thirdLargest != int.MinValue)
        {
            Console.WriteLine($"Third largest number = {thirdLargest}");
        }
        else
        {
            Console.WriteLine("Array does not have third largest");
        }
    }
}
