# URL: https://www.hackerrank.com/challenges/ruby-tutorial-object-methods
# Author: @otegecmis

def odd_or_even(number)
    return number.even?
end

(0...gets.to_i).each do |i|
    puts odd_or_even(gets.to_i)
end
