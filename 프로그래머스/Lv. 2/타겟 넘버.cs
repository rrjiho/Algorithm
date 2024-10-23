using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        return DFS(numbers, target, 0, 0);
    }
    
    public int DFS(int[] numbers, int target, int index, int currentSum)
    {
        if (index == numbers.Length)
            return currentSum == target ? 1 : 0;
        // 값이 누적되어 다시 처음 시작했던 호출까지 오게 되면 끝
        int add = DFS(numbers, target, index + 1, currentSum + numbers[index]);
        int sub = DFS(numbers, target, index + 1, currentSum - numbers[index]);
        
        return add + sub;
    }
}
