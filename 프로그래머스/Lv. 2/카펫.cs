using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int len = brown + yellow;
        
        for (int height = 3; height <= len / height; height++)
        {
            if (len % height == 0)
            {
                int width = len / height;
                
                if ((width - 2) * (height - 2) == yellow)
                {
                    answer[0] = width;
                    answer[1] = height;
                }
            }
        }
        
        return answer;
    }
} // 기하학적 규칙을 생각해서 품. 최소 3칸의 높이가 할당되고 총 넓이를 높이로 나눠떨어지는 것 중 노란색이 개수가 맞는지 확인하면 됨.
