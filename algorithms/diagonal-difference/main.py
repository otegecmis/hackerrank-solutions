# URL: https://www.hackerrank.com/challenges/diagonal-difference
# Author: @otegecmis

def diagonalDifference(arr):
    length = len(arr)
    primary = 0
    seconday = 0

    for i in range(length):
        primary += arr[i][i]
        seconday += arr[i][length - i - 1]

    return abs(primary - seconday)
