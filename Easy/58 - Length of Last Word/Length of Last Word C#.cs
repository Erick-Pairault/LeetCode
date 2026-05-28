public class Solution {
    public int LengthOfLastWord(string s) {
        int index = s.Length - 1;
        int length = 0;
        while(index >= 0) {
            if(s[index] == ' ' && length > 0) {
                return length;
            } else if (s[index] == ' ') {
                index--;
            } else {
                length++;
                index--;
            }
        }
        return length;
    }
}