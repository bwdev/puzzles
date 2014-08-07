_palindromes = []

(100..999).each do |x|
  (100..999).each do |y|
    i = x * y
    _str = i.to_s
    next if _str.length % 2 != 0
    chars = _str.split("")

    _palindromes.push(i) if chars == chars.reverse 
  end
end

puts _palindromes.sort.last
