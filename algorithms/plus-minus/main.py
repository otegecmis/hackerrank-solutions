# URL: https://www.hackerrank.com/challenges/plus-minus
# Author: @otegecmis

def plusMinus(arr):
    positive = 0
    negative = 0
    zeros = 0
    size = len(arr)

    for item in arr:
        if item == 0:
            zeros += 1
        elif item > 0:
            positive += 1
        else:
            negative += 1

    print(positive / size)
    print(negative / size)
    print(zeros / size)
