
class Node
  # attr_accessor :children
  #= Hash["a",Node.new,"b",Node.new,"c",Node.new,"n",Node.new,"e",Node.new,"t",Node.new,"o",Node.new]
  attr_accessor :letter

  def initialize(v)
    @letter = v
     @children = []
  end

def isward(word)
  book = ["cat","canon","ten","beet","nab","eat","can","bee"]
  for i in(0..book.length-1)
    if book[i]==word
      return true
    else
      return false
    end
  end
end

def findword()
end

def listpossibleword
arr=""
result = []
if  @letter != ""
  p   arr << @letter
     if p isward(arr)
     result << arr
     result << ","
     else
       for i in (0..@children.length-1)
          if p @children[i].letter != ""
           arr << @children[1]
             if isward(arr)
             result << arr
             result << ","
             end
          end
       end
     end
end
return result
puts result
end

def addword (word)
     let = word[0]
      did_i_find_it = false
      if @letter
         @children.each do |child|
               if child.letter == let
               did_i_find_it = true
               if word.length > 1
               child.addword(word.slice(1..word.length))
             end
              end
         end # end of Do

         if  did_i_find_it == false
          child=Node.new(let)
          puts ("Done" + let)
          @children << child
          if word.length > 1
          child.addword(word.slice(1..word.length))
        end
        end
    else
      @letter = let
      puts ("Done" + let)
      if word.length > 1
        addword(word.slice(1..word.length))
      end
    end
  end
end

dictionary = ["cat","canon","ten","beet","nab","eat"]
root= Node.new("*")
for i in (0..dictionary.length-1)
  root.addword(dictionary[i])
end
# try = []
#  p try = root.listpossibleword
