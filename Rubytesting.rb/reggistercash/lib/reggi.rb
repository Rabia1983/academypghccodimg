class Reggister
  def get_x (n)
numb = [20,10,1,0.25,0.10,0.05,0.01]
unit=["twenties","tens","single","quarters","dimes","nickles","pennies"]
result = []
  for i in (0..numb.length)
   while n > numb[i].to_i
    x1 = (n / numb[i]).round
    x2 = x1.round
    n = n - (x2 * numb[i])
   result << x1
   result << unit[i]
   end
   end
  return result
end
end

=begin
# group work
class CashRegister
  def makechange money

    twenties = 0

    tens = 0

    fives = 0

    single = 0

    quarters = 0

    dimes = 0

    nickles = 0

    pennies = 0
    change = []

    while money >= 20.00

    twenties = twenties + 1

    money = money - 20.00

    end
    while money >= 10.00

    tens = tens + 1

    money = money - 10.00

    end
  while money >= 5.00

    fives = fives + 1

    money = money - 5.00

    end
    while money >= 1.00

    single = single + 1

    money = money - 1

    end
    while money >= 0.25
    quarters = quarters +1
    money = money - 0.25
    end
    while money >= 0.10
    dimes = dimes + 1
    money = money - 0.10
    end
    while money >= 0.05
    nickles = nickles + 1
    money = money - 0.05
    end
    while money >= 0.01
    pennies = pennies + 1
    money = money - 0.01
    end
    options = [twenties , tens, fives, single, quarters, dimes, nickles, pennies]
    strings = ["twenties","tens","fives","single","quarters","dimes","nickles","pennies"]
    for denomination in (0...options.length)
      if (options[denomination] > 0)
        change << options[denomination].to_s + " " + strings[denomination]
      end
    end
    return change.join(", ")
    end
end
=end
