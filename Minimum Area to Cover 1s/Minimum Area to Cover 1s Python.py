class Solution(object):
    def minimumArea(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        rows = len(grid)
        cols = len(grid[0])

        for r in range(rows):
            for c in range(cols):
                value = grid[r][c]
                print(f"Row {r}, Col {c} => {value}")
