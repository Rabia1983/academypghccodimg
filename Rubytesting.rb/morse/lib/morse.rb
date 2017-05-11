class Morse
	#def initialize
@@Alpha_to_morse = {

	"a" => ".-",

	"b" => "-...",

	"c" => "-.-.",

	"d" => "-..",

	"e" => ".",

	"f" => "..-.",

	"g" => "--.",

	"h" => "....",

	"i" => "..",

	"j" => ".---",

	"k" => "-.-",

	"l" => ".-..",

	"m" => "--",

	"n" => "-.",

	"o" => "---",

	"p" => ".--.",

	"q" => "--.-",

	"r" => ".-.",

	"s" => "...",

	"t" => "-",

	"u" => "..-",

	"v" => "...-",

	"w" => ".--",

	"x" => "-..-",

	"y" => "-.--",

	"z" => "--..",

	" " => "   ",

	"1" => ".----",

	"2" => "..---",

	"3" => "...--",

	"4" => "....-",

	"5" => ".....",

	"6" => "-....",

	"7" => "--...",

	"8" => "---..",

	"9" => "----.",

	"0" => "-----"

}
#end

def to_morse(message)

  letters = message.split("")

  #word_in_morse = ""
	word_in_morse = []

  letters.each do |current_letter|

    ##word_in_morse += @@Alpha_to_morse[current_letter] + " "
		word_in_morse << @@Alpha_to_morse[current_letter]

		return word_in_morse.join(" ")

  end

return  word_in_morse

end

def to_alpha(message)
words = message.split("   ")
message_in_alpha = ""
words.each do |current_word|
letters = current_word.split(" ")
letters.each do |current_letter|
message_in_alpha += @@Alpha_to_morse.key(current_letter)
end
message_in_alpha += " "
end
return message_in_alpha

end
end
#
# puts "Would you like to translate to (m)orse or to the (a)lphabet?"
#
# direction = gets.chomp!.downcase
#
# puts "What is your message?"
#
# user_message = gets.chomp!.downcase
#
# if direction == "m"
#
#   print to_morse(user_message)
#
# elsif direction == "a"
#
#   print to_alpha(user_message)
#
# else
#
#   puts "Please select 'a' or 'm.'"
#
# end
