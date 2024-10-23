using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        
        Queue<int> progressQueue = new Queue<int>(progresses);
        Queue<int> speedQueue = new Queue<int>(speeds);
        
        while (progressQueue.Count > 0)
        {
            
            int queueSize = progressQueue.Count; // Dequeue 과정에서 동적으로 변할 수 있으니 
            for (int i = 0; i < queueSize; i++)  // 변수 저장 해놓고 사용해야 문제 없음
            {
                int progress = progressQueue.Dequeue();
                int speed = speedQueue.Dequeue();
                
                progress += speed;
                
                progressQueue.Enqueue(progress);
                speedQueue.Enqueue(speed);
            }
            
            int count = 0;
            while (progressQueue.Count > 0 && progressQueue.Peek() >= 100)
            {
                progressQueue.Dequeue();
                speedQueue.Dequeue();
                count++;
            }
            
            if (count > 0)
            {
                answer.Add(count);
            }       
        }
        
        
        return answer.ToArray();
    }
}
