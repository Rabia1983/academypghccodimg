# size = 10
grid = Array.new(10) {Array.new(10,0)}
grid[5][6]= 1
grid[2][4]= 1
grid.each do |i|
  puts i.join(" ")
end
