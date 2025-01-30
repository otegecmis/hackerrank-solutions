# URL: https://www.hackerrank.com/challenges/ruby-tutorial-unless
# Author: @otegecmis

def scoring(array)
    array.each do |user|
       unless user.is_admin?
           user.update_score
       end
    end
end
