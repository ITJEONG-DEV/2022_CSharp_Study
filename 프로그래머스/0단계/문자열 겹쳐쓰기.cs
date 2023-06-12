using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {       
        return my_string.Substring(0, s) + overwrite_string + my_string.Substring(s+overwrite_string.Length);
    }
}