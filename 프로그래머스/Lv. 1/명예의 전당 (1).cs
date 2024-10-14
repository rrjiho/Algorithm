using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
      
        List<int> list = new List<int>();
        list.Add(score[0]);
        answer[0] = score[0];
      
        for (int i = 1; i < score.Length; i++)
        {
            if (i < k)
            {
                list.Add(score[i]);
                if (list.Min() <= list[i])
                    answer[i] = list.Min();
                else
                    answer[i] = list[i];
            }
            else
            {
                if (list.Min() < score[i])
                {
                    list.Remove(list.Min());
                    list.Add(score[i]);
                    answer[i] = list.Min();
                }
                else
                {
                    answer[i] = list.Min();
                }                    
            }
        }
        
        return answer; // 누군가 보았을 때 해석에 어려움이 있을 수 있는 코드.
    }
}

/*
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> award = new List<int>();
        int count = 0;
        foreach(int s in score)
        {
            award.Add(s);
            award.Sort();
            if(award.Count>k)
                award.RemoveAt(0);
            answer[count++] = award[0];
        }
        return answer;
    }
}
같은 내용이지만 훨씬 직관적인 해석 가능.
*/
