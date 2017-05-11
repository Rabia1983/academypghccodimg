class Node

  attr_reader :value



  def initialize(node_value)
    @value = node_value
  end

  def add(value)
     if @value # we are full

      # we want to either create a new node

      # or send add to a node if the next one exists

      # Situation one: We have a @next, so call @next.add instead
         if @next
         @next.add(value)
         else
        # Situation two: We don't have an @next
        # => We create a new node with that value
         @next = Node.new(value)
         end

     else # we have no value
      @value = value
      end
  end



  def get(counter)

    if counter == 0
      return @value
    else
      if @next
        return @next.get(counter-1)
      else
        return nil
      end
    end
  end



  def length(length_so_far)

    if @value
      if @next
        @next.length(length_so_far + 1)
      else
        length_so_far + 1
      end
    else
      length_so_far
    end
  end
end



class LinkedList

  def initialize
    @start = Node.new(nil)
  end

  def add(thing_to_add)
    @start.add(thing_to_add)
  end

  def get(position)
    @start.get(position)
  end

  def length
    @start.length(0)
  end

end
