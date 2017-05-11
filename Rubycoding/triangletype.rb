# Should return ᐃ type:
#  0 : if ᐃ cannot be made with given sides
#  1 : acute ᐃ
#  2 : right ᐃ
#  3 : obtuse ᐃ

def triangle_type (a, b, c)
kind = 0
puts a
puts b
puts c
if c<a+b and a<b+c and b<a+c
   if c*c==a*a+b*b or a*a==b*b+c*c or b*b==a*a+c*c
       kind = 2
       elsif  c*c>a*a+b*b or a*a>b*b+c*c or b*b>a*a+c*c
       kind = 3
       elsif  c*c<a*a+b*b or a*a<b*b+c*c or b*b<a*a+c*c
       kind = 1

     end
end
return kind
end
