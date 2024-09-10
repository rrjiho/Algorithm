using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> list = new List<int>();

        foreach (int arr in numlist)
        {
            if (arr % n == 0)
                list.Add(arr);
        }

        int[] answer = list.ToArray();

        // int[] answer = numlist.Where(x => x % n == 0).ToArray();

        return answer;
    }
}
