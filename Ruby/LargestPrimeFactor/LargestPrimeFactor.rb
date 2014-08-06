class Factor
  def self.get_factors(input)
    _iterator = 2
    _factors = []

    while input > 1
      _f = input / _iterator
      next if _f % 2 == 0
      puts (_f).to_s

      return _f if is_prime?(_f)
      _iterator += 1
    end
  end

  def self.is_prime?(input)
    _iterator =2 

    while _iterator <= input - 1 
      return false if input % _iterator == 0 && input != _iterator
      _iterator += 1
    end

    return true;
  end
end


_input = 600851475143
_answer = Factor.get_factors(_input)

puts _answer
