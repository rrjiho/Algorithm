using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int minFive = 5;
        int[] answer = new int[num_list.Length - minFive];
        
        Array.Sort(num_list);
        
        for (int i = minFive; i < num_list.Length; i++)
        {
            answer[i - minFive] = num_list[i];
        }
        return answer;
    }
}

// num_list.OrderBy(o => o).Skip(5).ToArray(); 아주 간단한 LINQ 구문
