class Solution(object):
    def isPowerOfFour(self, n):
        """
        :type n: int
        :rtype: bool
        """
        for i in range(0, 32):
            if 4**i == n:
                return True
            elif 4**i > n:
                return False