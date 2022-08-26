public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int dist = arr[1] - arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i + 1] - arr[i] != dist)
                return false;
        return true;
    }
}
