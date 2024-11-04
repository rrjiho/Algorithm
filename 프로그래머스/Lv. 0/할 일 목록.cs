using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        List<string> str_list = new List<string>();
        
        for (int i = 0; i < todo_list.Length; i++)
        {
            if (!finished[i])
                str_list.Add(todo_list[i]);
        }
        
        return str_list.ToArray();
    }
}
