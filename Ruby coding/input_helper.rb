class Input_helper

	def get_text(prompt)
  puts prompt
  return gets.chomp
  end
  def get_number(prompt)
  puts prompt
  answer = gets.chomp


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

		@inputs = ["John", "37", "hello", "party time"]

		# @inputs << "John"

		# @inputs << "37"

	end



	private

		def get_next_input

			next_input = @inputs.shift

			puts "> #{next_input}"

			return next_input

		end



end



ih = Input_faker.new



some_text = ih.get_text("Hey, what is your name?")

puts some_text



some_number = ih.get_number("How old are you?")

puts "You will be #{some_number + 5} in 5 years"
