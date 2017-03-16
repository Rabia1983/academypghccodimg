require './lib/template_engine'

tr = Template_reader.new

tr.set_template "This is the {{whereami}}"

puts tr.run_template({"whereami" => "console"})


# run it as normal ruby program.rb in the console!!!!!
