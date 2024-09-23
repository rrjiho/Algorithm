using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length - 2; i++)
            for (int j = i + 1; j < nums.Length - 1; j++)
                for (int k = j + 1; k < nums.Length; k++)
                {        
                    int _flag = 0;
                    int num = nums[i] + nums[j] + nums[k];
                    for (int r = 2; r < num; r++)
                    {
                        if (num % r == 0)
                        {
                            _flag++;
                            break;
                        }
                    }
                    if (_flag == 0)
                        answer++;
                }

        return answer;
    }
}
