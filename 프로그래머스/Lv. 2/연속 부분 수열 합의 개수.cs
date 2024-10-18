using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        HashSet<int> sums = new HashSet<int>();
        int len = elements.Length;
        
        int[] cpElements = new int[len * 2];
        Array.Copy(elements, cpElements, len);
        Array.Copy(elements, 0, cpElements, len, len);
        
        for (int i = 0; i < len; i++)
        {
            int sum = 0;
            for (int j = 0; j < len; j++)
            {
                sum += cpElements[i + j];
                sums.Add(sum);
            }
        }
        
        return sums.Count;
    }
}
// HashSet 사용하면 중복이 없다는 것을 미리 알고 있었고 잘 적용함
// 원형을 선형으로 생각하고 만들어서 적용하는 아이디어가 중요
// 무엇이든지 단순하게 만들어서 풀면 쉽다는 것
// 선형으로 만들면 부분 합 이라는 아이디어가 쉽게 떠오름
