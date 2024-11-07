using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";
        
        foreach (int i in index_list)
        {
            answer += my_string[i];
        }
        
        return answer;
    }
}
// 이 문제는 1000개 이하의 길이여서 그냥 진행했지만
// 많은 수의 문자열을 재배치 해야하는 경우 당연히 StringBuilder를 사용하는게 옳다. Append()
