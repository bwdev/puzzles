_range = 0..999
_sum = 0

_range.each do |i|
  if i % 3 == 0 || i % 5 == 0
    _sum += i
  end
end

puts _sum.to_s
