class Auto_complete

  def initialize
    @library = ["hello", "car", "cab", "man", "mane", "married", "hello world", "hero"]
    @library_matches = []
  end

  def find_matches word
    @library.each do |library_word|
    #for i in 0..@library.length - 1
      #library_word = @library[i]
        if library_word[0...word.length] == word
          @library_matches << library_word
        end
      end
      return @library_matches
  end

  def find_exact_match word
    @library.each do |library_word|
    #for i in 0..@library.length - 1
      #library_word = @library[i]
        if library_word  == word
            return "we found a match: #{word}"
        end
      end

  end
end
