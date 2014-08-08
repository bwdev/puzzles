_answer = 0
_iterator = 380 #the lowest divisible number of 19 & 20

while _answer == 0
  _tester = 20
  while _iterator % _tester == 0
    _tester -= 1
    if _tester == 1
      _answer = _iterator
      break
    end
  end
  _iterator += 1
end

puts _answer
