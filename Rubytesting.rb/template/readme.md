We want to be able to read in a template and replace all of the template fields with real info.

ex:

>Hello {{name}},

>

>Thank you for attending >{{school}}. I'm sorry to >inform you, you've been >kicked out for >{{somereason}}.

>

>Thanks,

>{{dean}}

>

replace {{name}}, {{school}}, {{somereason}}, {{dean}} with appropriate values

set_template template # sets the value of the internal template so other functions will run correctly

run_template hash (name_of_field, value)  # returns a string with the filled in template

`set_template "Hi {{name}}"`

`run_template {"name" => "John", "school" =>"Academy"}`

"Hi John"

`run_template {"name" => "Rory"}`

"Hi Rory"

get_template_fields   # returns returns a string array with all of the field names

`set_template "Hi {{name}}, today is {{day}}"`

`get_template_fields`

["name", "day"]
