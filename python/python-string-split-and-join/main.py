# URL: https://www.hackerrank.com/challenges/python-string-split-and-join
# Author: @otegecmis

def split_and_join(line):
    arr = line.split()
    return "-".join(arr)

if __name__ == '__main__':
    line = input()
    result = split_and_join(line)
    print(result)
