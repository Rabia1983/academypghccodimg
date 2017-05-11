class Template_reader

  #ttr_accessor :template



  def set_template template

    @template = template

  end



  def get_template_fields

    temp_array = @template.scan(/{{[a-zA-Z\s]*}}/)

    return_array = []

    i=0

    temp_array.each do |fixme|

      return_array << fixme.gsub("{{", "").gsub("}}", i.to_s)

      i=i+1  #fixme.sub(/^{{/, "").sub(/\}}/, "")

    end

    return return_array

  end



  def run_template input_hash

    temp_template = @template

    i = 0

    input_hash.each_pair do |scotty, kirk|



      scotty = scotty[0...scotty.length - 1]

      temp_template = temp_template.gsub("{{" + scotty.to_s + "}}", kirk)

      i += 1

    end

    return temp_template

  end



  def make_hash (get_template, user_answer)

    hash_answers = {}



    #hash_answers = Hash[*get_template.zip(user_answer)]



    #get_template.each_with_index do |value, index|

    #  hash_answers[value] = user_answer[index]

    #end

    get_template.zip(user_answer) { |a,b| hash_answers[a.to_sym] = b }

    #hash_answers = get_template.zip(user_answer).to_h



    #i = 0

    #while i < user_answer.length

    #  hash_answers[i] = { "#{get_template[i]}" => user_answer[i] }

    #  i += 1

    #end

    return hash_answers

  end



end
