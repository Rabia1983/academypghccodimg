class Template


def initialize(user_title, user_author, user_date, user_text)
@user_title = user_title
@user_author = user_author
@user_date = user_date
@user_text = user_text
end

def get_info()
"The title is #{@user_title} and the body of the text is: #{@user_text} \n Written by: #{@user_author} \n PuDate: #{@user_date} \n Entry time = #{Time.now.strftime("%d/%m/%Y %H:%m")} "
end
end

text_catalogue = []
i = 1
while true
puts "What would you like ot do? (S)ave or (r)etreive?"
u_response = gets.downcase.chomp
if u_response  == "s"
puts "what is the title?"
user_title = gets.chomp
puts "what is the the name of the author?"
user_author = gets.chomp
puts " what is the publish date?"
user_date = gets.chomp
user_text = "TEXT"

text_catalogue[i] = Template.new(user_title, user_author, user_date, user_text)
puts "your number is #{i}"
i += 1
elsif u_response == "r"
puts "What numer do you want?"
number = gets.chomp
puts text_catalogue[number.to_i].get_info
end
puts "Do you want to continue?"
break if gets.chomp == "no"
end
