class Solution {
    public String largestGoodInteger(String num) {
        if(num.isEmpty())
            return ""; 
        String largest = "";
        int count = 1;
        char temp = num.charAt(0);
        
        for(int i = 1; i < num.length(); i++)
        {
            // If we have the same consecutive numbers in char
            if(num.charAt(i) == temp) {
                count++;
            } else { // If the number in the index is different from temp
                count = 1;
            }
            if (count == 3) {
                if(num.charAt(i) > largest.charAt(0)) {
                    String new_lagrest;
                    new_largest.append(num.charAt(i));
                    new_largest.append(num.charAt(i));
                    new_largest.append(num.charAt(i));
                    largest = new_largest;
                }
            }
            temp = num.charAt(i);
        }
        return largest;
    }
}