_sum_squares = 0
_square_sums = 0

(1..100).each do |i|
  _sum_squares += i**2
  _square_sums += i
end

_answer = (_square_sums**2) - _sum_squares 
puts _answer
