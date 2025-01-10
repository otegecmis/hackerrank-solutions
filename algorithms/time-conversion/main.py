# URL: https://www.hackerrank.com/challenges/time-conversion
# Author: @otegecmis

def timeConversion(s):
    time_parts = s.split(":")
    
    seconds_and_period = time_parts[2]
    period = seconds_and_period[-2:]
    seconds = seconds_and_period[:2]

    time_parts[2] = seconds
    time_parts.append(period)

    if period == "PM" and time_parts[0] != "12":
        time_parts[0] = str(int(time_parts[0]) + 12)
    elif period == "AM" and time_parts[0] == "12":
        time_parts[0] = "00"

    time_parts.pop(3)
    return ":".join(time_parts)
