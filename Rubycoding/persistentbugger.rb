def persistence(n)
   if n<10
     return 0
   else
     count=0
         while n > 9
          puts n
          mul=1
          str=n.to_s
          for i in (0..str.length-1)
           mul=mul*str[i].to_i
          end
           p n = mul
          count=count+1
       end
   end
   return count
end
