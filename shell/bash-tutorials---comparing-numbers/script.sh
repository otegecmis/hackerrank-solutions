#!/bin/bash

# URL: https://www.hackerrank.com/challenges/bash-tutorials---comparing-numbers
# Author: @otegecmis

read x
read y

if [ $x -lt $y ]; then
    echo "X is less than Y"
elif [ $x -gt $y ]; then
    echo "X is greater than Y"
else
    echo "X is equal to Y"
fi
