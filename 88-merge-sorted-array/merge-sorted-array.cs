public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       int num1i =m-1; // place till sorted array belongs
       int num2j =n-1; // Place till sorted array belongs

        int size  = m+n-1;

        while(num1i >=0 && num2j >=0)
        {
            if(nums1[num1i] > nums2[num2j])
            {
                nums1[size] = nums1[num1i];
                --num1i;
                --size;
            }
            else
            {
                nums1[size] = nums2[num2j];
                --num2j;
                --size;
            }
        }

        while(num1i >=0)
        {
            nums1[size] = nums1[num1i];
            --size;
            --num1i;
        }

        while(num2j >=0)
        {
            nums1[size] = nums2[num2j];
            --size;
            --num2j;
        }
    }
}