class Solution:
    def sortColors(self, nums: List[int]) -> None:
        i=0
        j=0
        k=0

        for x in nums:
            if x==0:
                i+=1
            elif x==1:
                j+=1
            else:
                k+=1

        
        for x in range(len(nums)):
            if i>0:
                nums[x]=0
                i-=1
            elif j>0:
                nums[x]=1
                j-=1
            else:
                nums[x]=2
                k-=1
