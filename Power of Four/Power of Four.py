class Solution(object):
    def isPowerOfFour(self, n):
        """
        :type n: int
        :rtype: bool
        """
        if n<= pow(-2,31) or n>= pow(2,31) - 1:
            return False
        elif n == 1 or n%4 == 0:
            return True
        else:
            return False