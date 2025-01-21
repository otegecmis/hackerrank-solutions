#!/bin/bash

# URL: https://www.hackerrank.com/challenges/bash-tutorials---getting-started-with-conditionals
# Author: @otegecmis

read input

if [[ $input == "Y" || $input == "y" ]]; then
    echo "YES"
elif [[ $input == "N" || $input == "n" ]]; then
    echo "NO"
fi
