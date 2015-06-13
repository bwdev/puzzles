class CardDeck 
 @@cards = []

  def initialize
    (1..4).each do |d|
      (1..13).each do |c|
       @@cards.push(Card.new(c,d)) 
      end
    end
  end
  
  def self.shuffle
    #Fisher-Yates algorithm
    t = @@cards.length
    random = Random.new

    while(t > 1)
      t = t - 1
      _r = random.rand(t)
      _tmp = @@cards[t]
      @@cards[t] = @@cards[_r]
      @@cards[_r] = _tmp
    end
  end

  def self.show_cards
    @@cards.each do |c|
      puts "#{c.name} of #{c.suit.name}"
    end
  end
end

class Card
  attr_accessor :id, :suit, :name
  def initialize(id, suit_id)
    @id = id
    @suit = Suit.new(suit_id) 
    @name = get_name(id)
  end

  def get_name(id)
      case id
      when 1
        return "ace"
      when 2
        return "two"
      when 3
        return "three"
      when 4
        return "four"
      when 5
        return "five"
      when 6
        return "six"
      when 7
        return "seven"
      when 8
        return "eight"
      when 9
        return "nine"
      when 10
        return "ten"
      when 11
        return "jack"
      when 12
        return "queen"
      when 13
        return "king"
    end
  end
end

class Suit 
  attr_accessor :id, :name
  def initialize(id)
    @id = id
    @name = get_name(id)
  end

  private
  def get_name(id)
      case id
      when 1
        return "Spades"
      when 2
        return "Clubs"
      when 3
        return "Diamonds"
      when 4
        return "Hearts"
    end
  end
end

_deck = CardDeck.new
CardDeck.show_cards
CardDeck.shuffle
CardDeck.show_cards
