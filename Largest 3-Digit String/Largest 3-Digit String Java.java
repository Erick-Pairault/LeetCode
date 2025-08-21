class Solution {
    public String largestGoodInteger(String num) {
        if (num.isEmpty()) return "";
        String largest = "";
        int count = 1;

        for (int i = 1; i < num.length(); i++) {
            if (num.charAt(i) == num.charAt(i - 1)) {
                count++;
            } else {
                count = 1;
            }

            if (count == 3) {
                char number = num.charAt(i);
                String temp = "" + number + number + number;
                if (largest.isEmpty() || number > largest.charAt(0)) {
                    largest = temp;
                }
                count = 3;
            }
        }
        return largest;
    }
}