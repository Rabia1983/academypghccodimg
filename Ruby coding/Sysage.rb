class Input
attr_accessor :storage

def get_input
  puts "Would you like to (S)ave, (R)etreive a message or (E)xit ?"
  return gets.chomp.downcase
end

def get_message
  puts "what is your id ?"
  id = gets.chomp
  while id.match(/\D/)
  puts " please try numbers only!!! "
      id = gets.chomp
  end
return p "your message is : #{@storage[id.to_i]} "
end

 def save_message
   puts "what is your message?"
  @storage << gets.chomp
   return p "your message ID is : # #{@storage.length() -1 }"
 end


def initialize
  @storage = [ ]
end
end

i= true
apple = Input.new

while i == true
  answer = apple.get_input
  if answer == "s"
     apple.save_message
  elsif answer == "r"
      apple.get_message
 elsif answer == "e"
   i=false
 else
   puts "I can't understand what you mean !!"
 end
end

=begin   # Jhon way using require
require './input_helper'



input = Input_helper.new

messages = []

keep_looping = true



while keep_looping #== true



	menu_choice = input.get_text "Would you like to S)ave, R)etrieve, or E)xit?"



	if(menu_choice.downcase == 'e')

		puts "Thanks for using the system!"

		keep_looping = false

	elsif menu_choice.downcase == 'r'

		id = input.get_number "What is the ID of the message you wish to retrieve?"

		puts "Your message is: #{messages[id]}"

	elsif menu_choice.downcase == 's'

		message = input.get_text "What is your message?"

		messages << message

		puts "Your ID is: #{messages.length - 1}"

	end



end
=end
=begin # another way from john using testing in one time from an array by faker class
class Input_helper

	def get_text(prompt)

		puts prompt

		return gets.chomp

	end



	def get_number(prompt)

		puts prompt

		answer = gets.chomp

		# could replace the two lines above with this line:

		# answer = get_text(prompt)



		# If they typed anything that wasn't a number, ask them again and again until they have only typed numbers

		while answer.match(/\D/)

			puts "Please type numbers only, try again:"

			answer = gets.chomp

		end

		return answer.to_i

	end

end



class Input_faker

	def get_text prompt

		puts prompt

		return get_next_input

	end



	def get_number prompt

		puts prompt

		return get_next_input.to_i

	end



	def initialize

		@inputs = []

		#@inputs = ["John", "37", "hello", "party time"]

		@inputs << "S"

		@inputs << "Hello there"

		@inputs << "s"

		@inputs << "Hello 2"

		@inputs << "r"

		@inputs << "0"

		@inputs << "r"

		@inputs << "1"

		@inputs << "e"

	end



	private

		def get_next_input

			next_input = @inputs.shift

			puts "> #{next_input}"

			return next_input

		end



end





class Message_store

	def save_message message

		@messages << message

		return @messages.length - 1

	end



	def retrieve_message id

		return @messages[id]

	end



	def initialize

		@messages = []

	end

end





input = Input_faker.new

messages = Message_store.new

keep_looping = true



while keep_looping #== true



	menu_choice = input.get_text "Would you like to S)ave, R)etrieve, or E)xit?"



	if(menu_choice.downcase == 'e')

		puts "Thanks for using the system!"

		keep_looping = false

	elsif menu_choice.downcase == 'r'

		id = input.get_number "What is the ID of the message you wish to retrieve?"

		puts "Your message is: #{messages.retrieve_message(id)}"

	elsif menu_choice.downcase == 's'

		message = input.get_text "What is your message?"

		puts "Your ID is: #{messages.save_message(message)}"

	end



end

=end
