using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";

        foreach (char s in rsp)
        {
            switch(s)
            {
                case '2':
                    answer += '0';
                    break;
                case '0':
                    answer += '5';
                    break;
                case '5':
                    answer += '2';
                    break;
            }
        }

        // Select 각 요소 조건에 따라 반환 후 Concat 하나의 문자열로 만듦
        //string answer = String.Concat(rsp.Select(x => x == '2' ? '0' : x == '0' ? '5' : '2'));
      
        return answer;
    }
}
