class RomanConverter
  def convert(number)
    result= ""
    @denomination.each do |denomination|
      while number >= denomination[:value]
        number -= denomination [:value]
        result << denomination[:name]
      end
    end
    result
  end

  #constructor /initializer
  def initialize
    @denomination=[]
    add_denomination("C",100)
    add_denomination("XC",90)
    add_denomination("L",50)
    add_denomination("XL",40)
    add_denomination("X",10)
    add_denomination("IX",9)
    add_denomination("V",5)
    add_denomination("IV",4)
    add_denomination("I",1)
  end
  def add_denomination(name,value)
    @denomination<<{name:name,value:value}
  end
end
