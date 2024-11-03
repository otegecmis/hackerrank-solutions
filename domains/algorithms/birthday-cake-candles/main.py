# https://www.hackerrank.com/challenges/birthday-cake-candles

def birthdayCakeCandles(candles):

    numbers = sorted(candles)
    biggest_number = numbers[len(numbers) - 1]
    
    count = 0

    for number in numbers:
        if number == biggest_number:
            count += 1

    return count

data = [3, 2, 1, 3]
result = birthdayCakeCandles(data)

print(result)