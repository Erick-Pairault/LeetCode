public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int maxArea = 0;

        for (int r = 0; r < rows; r++) {

            // Build height of consecutive 1s ending at this row
            for (int c = 0; c < cols; c++) {
                if (matrix[r][c] == 1 && r > 0) {
                    matrix[r][c] += matrix[r - 1][c];
                }
            }

            // Copy current row heights
            int[] heights = new int[cols];
            for (int c = 0; c < cols; c++) {
                heights[c] = matrix[r][c];
            }

            // Sort descending so tallest columns are grouped together
            Array.Sort(heights);
            Array.Reverse(heights);

            // Try each width
            for (int width = 1; width <= cols; width++) {
                int height = heights[width - 1];
                int area = height * width;
                maxArea = Math.Max(maxArea, area);
            }
        }

        return maxArea;
    }
}