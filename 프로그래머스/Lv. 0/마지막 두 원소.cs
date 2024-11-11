using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int len = num_list.Length;
        List<int> list = num_list.ToList();
        
        if (num_list[len - 1] > num_list[len - 2])
            list.Add(num_list[len - 1] - num_list[len - 2]);
        else
            list.Add(num_list[len - 1] * 2);
        
        return list.ToArray();
    }
}

/*using System; 이 풀이도 깔끔해서 참고.

public class Solution {
    public int[] solution(int[] num_list) 
    {
        int[] answer = new int[num_list.Length + 1];
        Array.Copy(num_list, answer, num_list.Length);
        int a = num_list[num_list.Length - 2];
        int b = num_list[num_list.Length - 1];
        answer[answer.Length - 1] = b > a ? b - a : b * 2;
        return answer;
    }
}*/
