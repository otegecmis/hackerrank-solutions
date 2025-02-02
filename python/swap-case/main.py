# URL: https://www.hackerrank.com/challenges/swap-case
# Author: @otegecmis

def swap_case(s):
    temp = []

    for item in s:
        if item == item.upper():
            temp.append(item.lower())
        else:
            temp.append(item.upper())

    return "".join(temp)

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)
