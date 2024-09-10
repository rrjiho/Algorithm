using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> list = new List<int>();
        
        char _zero = '0';
        char _nine = '9';
        
        foreach(char s in my_string)
        {
            if(s >= _zero && s <= _nine)
            {
                list.Add((int)s - 48);
            }
        }
        
        int[] answer = list.ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}
