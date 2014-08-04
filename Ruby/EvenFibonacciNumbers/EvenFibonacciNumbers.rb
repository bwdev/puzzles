_answer = 0

_cap = 4000000
_x = 0
_y = 1
_z = _x + _y

while _z < _cap
  _x = _y
  _y = _z
  _z = _x + _y

  _answer += _y if _y % 2 == 0
end

puts _answer.to_s
