require './lib/template_engine'

#require './Star Wars.txt'



mad_lib = Template_reader.new

mad_lib.set_template(File.read('./Star Wars.txt'))



get_template = []

user_answers = []

get_template = mad_lib.get_template_fields



i = 0

while i < get_template.length

  puts "Type in a #{get_template[i]}: "

  user_answers << gets.chomp

  i += 1

end

p get_template

p user_answers





completed_hash = mad_lib.make_hash(get_template, user_answers)

p completed_hash

madlib_done = mad_lib.run_template(completed_hash)



p madlib_done
