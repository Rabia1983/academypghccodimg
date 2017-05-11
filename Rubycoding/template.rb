# def do_template the_template
template = File.read('./template.txt')

 while template.include?(']')
   j=template.index('[')
   k=template.index(']')
    if template[j..k]=="[person]"
      template[j..k]= "best boy"
    elsif template[j..k]=="[adjective]"
      template[j..k]= "bad"
    elsif template[j..k]=="[Word Not Submitted]"
      template[j..k]= "think"
    else template[j..k]=="[adjective(quality)]"
        template[j..k]= "should be"
      end
   puts template
 end
