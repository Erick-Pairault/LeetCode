public class Solution {
    public int NumberOfSpecialChars(string word) {
        HashSet<char> set = new HashSet<char>(word);
        int special = 0;
        if(set.Contains('a') && set.Contains('A')) {
            special++;
        }
        if(set.Contains('b') && set.Contains('B')) {
            special++;
        }
        if(set.Contains('c') && set.Contains('C')) {
            special++;
        }
        if(set.Contains('d') && set.Contains('D')) {
            special++;
        }
        if(set.Contains('e') && set.Contains('E')) {
            special++;
        }
        if(set.Contains('f') && set.Contains('F')) {
            special++;
        }
        if(set.Contains('g') && set.Contains('G')) {
            special++;
        }
        if(set.Contains('h') && set.Contains('H')) {
            special++;
        }
        if(set.Contains('i') && set.Contains('I')) {
            special++;
        }
        if(set.Contains('j') && set.Contains('J')) {
            special++;
        }
        if(set.Contains('k') && set.Contains('K')) {
            special++;
        }
        if(set.Contains('l') && set.Contains('L')) {
            special++;
        }
        if(set.Contains('m') && set.Contains('M')) {
            special++;
        }
        if(set.Contains('n') && set.Contains('N')) {
            special++;
        }
        if(set.Contains('o') && set.Contains('O')) {
            special++;
        }
        if(set.Contains('p') && set.Contains('P')) {
            special++;
        }
        if(set.Contains('q') && set.Contains('Q')) {
            special++;
        }
        if(set.Contains('r') && set.Contains('R')) {
            special++;
        }
        if(set.Contains('s') && set.Contains('S')) {
            special++;
        }
        if(set.Contains('t') && set.Contains('T')) {
            special++;
        }
        if(set.Contains('u') && set.Contains('U')) {
            special++;
        }
        if(set.Contains('v') && set.Contains('V')) {
            special++;
        }
        if(set.Contains('w') && set.Contains('W')) {
            special++;
        }
        if(set.Contains('x') && set.Contains('X')) {
            special++;
        }
        if(set.Contains('y') && set.Contains('Y')) {
            special++;
        }
        if(set.Contains('z') && set.Contains('Z')) {
            special++;
        }
        return special;
    }
}