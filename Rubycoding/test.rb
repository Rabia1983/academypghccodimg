#puts "your age for after 5 years is:" + (age.to_i+5).to_s

=begin // my way
puts "what is the length and the width of your garden box"
length = gets
width = gets
area= (length.to_i * width.to_i)
puts "your garden area is: "+ area.to_s
puts "your garden perimeter is:"+((length.to_i + width.to_i)*2).to_s
puts "what do you want to plant "
wanted = gets.downcase.chomp!
if wanted.to_s == "carrot"
  puts "you can plant "+ area.to_s+ " carrots in your garden"
end
if wanted.to_s == "corn"
 p "you can plant "+ ((3* area)/16).to_s + " corns in your garden"
end
if wanted.to_s == "beet"
 p "you can plant "+ ((9* area)/16).to_s + " beets in your garden"
end

=end
#garden plants john way
=begin
puts "What is the length of your garden box?"

length = gets.chomp.to_i



puts "What is the width of your garden box?"

width = gets.chomp.to_i



area = length * width



print "Your perimeter is #{(length * 2) + (width * 2)}"

puts " and your area is #{area}"



puts "What are you planting? corn, carrots, or beets?"

answer = gets.chomp.downcase



if answer == "corn"

	puts "You can plant #{area.to_f/16 * 3} corn"

elsif answer == "carrots"

	puts "You can plant #{area.to_f/16 * 16} carrots"

elsif answer == "beets"

	puts "You can plant #{area.to_f/16 * 9} beets"

end
=end



=begin // birthday example
puts "What month were you born in?"

month = gets.chomp.capitalize

case month

when "December", "January", "February"

  puts "You were born #{month.capitalize} which is in the Winter. So cold!"

when "March", "April", "May"

  puts "You were born in #{month.capitalize} which is in the Spring. How pretty!"

when "June", "July", "August"

  puts "You were born in #{month.capitalize} which is in the Summer. Hot, hot, hot!"

when "September", "October", "November"

  puts "You were born in #{month.capitalize} which is in the Fall. I was too!"

else

  puts "Are you sure that is a month?"

end
=end
=begin //FIZZBUZZ
counter = 0
while counter < 100
    counter = counter+1
    if counter%3==0 && counter%5==0
      puts "FizzBuzz"
  elsif  counter%3==0
      puts "Fizz"
  elsif counter%5==0
      puts "Buzz"
    else
      puts counter
    end
end
=end
=begin
#range =1..100
#range.each do |i|
100.downto(1)do |i|
    if i%3==0 && i%5==0
      puts "FizzBuzz"
  elsif  i%3==0
      puts "Fizz"
  elsif i%5==0
      puts "Buzz"
    else
      puts i
    end
end
=end
=begin
store =[]
i=true
while i
puts "What do you like to do (S)ave , (R)etrive or (Q)uit "
answer=gets.upcase.chomp!
if answer=="S"
  puts "what is the message which you want to save"
  message = gets.chomp.downcase
  store << message
  puts "youe ID is " + (store.index(message)).to_s

elsif answer=="R"
  puts "what is your Id"
  id=gets.to_i
  puts "your message is "+ (store[id]).to_s
elsif answer=="Q"
   i=false
else
  puts "please retry I did not understand!"
end
end
=end


  #while i<word.length

 #end
#end
