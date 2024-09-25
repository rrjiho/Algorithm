class Program
{ 
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            // 왼쪽과 오른쪽 배열로 쪼개서 재귀로 돌림
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[arr.Length];

        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {    // 왼쪽 오른쪽 비교해서 넣고 +1 해줌
            if (arr[i] <= arr[j])
            {
                temp[k++] = arr[i++];
            }
            else
            {
                temp[k++] = arr[j++];
            }
        }

        while (i <= mid)
        {
            temp[k++] = arr[i++];
        }

        while (j <= right)
        {
            temp[k++] = arr[j++];
        }

        for (int l = left; l <= right; l++)
        {
            arr[l] = temp[l];
        }
    }
}

/*
  디버깅을 해보면 한쪽 쪼갠 후 병합 그 다음 쪼개고 병합 ... (다 쪼개 놓고 병합이 아니라 끝까지 쪼개고 붙인다음 다시 쪼개는 것을 반복 -> 재귀함수 순서 생각하면 됨)
*/
