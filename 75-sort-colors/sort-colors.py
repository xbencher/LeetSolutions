class Solution:
    def sortColors(self, nums: List[int]) -> None:
        i=0
        j=0
        k=len(nums)-1

        while j<=k:
            if nums[j]==2:
                temp=nums[j]
                nums[j]=nums[k]
                nums[k]=temp
                k-=1
            elif nums[j]==0:
                temp=nums[j]
                nums[j]=nums[i]
                nums[i]=temp
                i+=1
                j+=1
            else:
                j+=1
