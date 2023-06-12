using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string[] arr) {
        StringBuilder result = new StringBuilder();
        
        for(int i=0; i<arr.Length; i++) {
            result.Append(arr[i]);
        }
        
        return result.ToString();
    }
}