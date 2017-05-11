puts "enter what do you want to calculate"
string = gets.chomp
   num=[]
   i=0
  (string.to_s).split("").each do |d|
     if d =="+" || d =="*" || d =="-" || d =="/"
      num[i]=d
     else
     num[i]=d.to_i
     end
    i=i+1
  end
  puts num.to_s

while num.size >1
  k=0
  while k < num.size
    if num[k] == "*"
    num[k+1]= num[k-1] * num[k+1]
    num.delete_at(k)
    num.delete_at(k-1)
     puts num.to_s
     else
    num[k]=num[k]
     k=k+1
    end
   end


     k=0
  while k < num.size
    if num[k] == "/"
    num[k+1]= num[k-1].to_f / num[k+1].to_f
    num.delete_at(k)
    num.delete_at(k-1)
     puts num.to_s
     else
    num[k]=num[k]
     k=k+1
    end
   end

      k=0
  while k < num.size
    if num[k] == "-"
    num[k+1]= num[k-1] - num[k+1]
    num.delete_at(k)
    num.delete_at(k-1)
     puts num.to_s
     else
    num[k]=num[k]
     k=k+1
    end
   end

        k=0
  while k < num.size
    if num[k] == "+"
    num[k+1]= num[k-1] + num[k+1]
    num.delete_at(k)
    num.delete_at(k-1)
     puts num.to_s
     else
    num[k]=num[k]
     k=k+1
    end
   end

   end
   puts "your answer is " + num.to_s


## WHAT IS THIS LINE MEANS string.split.map(&:capitalize).join(' ')

#   def dasherize_number(num)
#   arr = []
#   num1=[]
#   i=0
#   (num.to_s).split("").each do |d|
#     num1[i]=d.to_i
#     i=i+1
#   end
#     for i in (0...num1.length)
#
#     if num1[i]%2 ==0
#     arr << num1[i].to_s
#
#     elsif num1[i]%2 !=0
#
#       if  i == 0
#
#          arr << num1[i].to_s
#          arr << '-'
#
#       elsif  i == num.to_s.length-1
#
#         arr << '-'
#         arr << num1[i].to_s
#       elsif num[i-1]%2 !=0 && num[i+1]%2 !=0
#         arr << num1[i].to_s
#       else
#         arr << '-'
#         arr << num1[i].to_s
#         arr << '-'
#       end
#     end
#
#   end #end of for
#   # puts num
#   result = ""
#   arr.each  do |j|
#   result = result + j
# end
#   puts result
#   return result
# end
