class Solution(object):
    def minimumArea(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        if not grid:
                return 0

        left = right = up = down = None

        for r, row in enumerate(grid):
            for c, val in enumerate(row):
                if val == 1:
                    if left is None:   # first 1 found
                        left = right = c
                        up = down = r
                    else:
                        left = min(left, c)
                        right = max(right, c)
                        up = min(up, r)
                        down = max(down, r)

        if left is None:   # no 1s in grid
            return 0

        return (down - up + 1) * (right - left + 1)