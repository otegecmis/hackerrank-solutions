# URL: https://www.hackerrank.com/challenges/birthday-cake-candles
# Author: @otegecmis

def birthdayCakeCandles(candles):
    numbers = sorted(candles)
    biggest_number = numbers[len(numbers) - 1]
    
    count = 0

    for number in numbers:
        if number == biggest_number:
            count += 1

    return count
