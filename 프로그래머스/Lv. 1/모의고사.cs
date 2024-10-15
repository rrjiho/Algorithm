using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
        
        int[] array = new int[3];
        int maxcnt = 0;
        
        int[] arr1 = {1,2,3,4,5};
        int[] arr2 = {2,1,2,3,2,4,2,5};
        int[] arr3 = {3,3,1,1,2,2,4,4,5,5};

        List<int> list = new List<int>();
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == arr1[i % arr1.Length])
                array[0]++;
            if (answers[i] == arr2[i % arr2.Length])
                array[1]++;
            if (answers[i] == arr3[i % arr3.Length])
                array[2]++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxcnt)
                maxcnt = array[i];
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxcnt)
                list.Add(i + 1);
        }

        return list.ToArray();
    }
}
