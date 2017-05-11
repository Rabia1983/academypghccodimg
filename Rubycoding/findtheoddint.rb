def find_it(seq)
 print seq
 if seq.length == 1
 return seq[0]
 end
  for i in (0..seq.length-1)
     count = 1
       for j in (0..seq.length-1)
         if  seq[i] ==seq[j]
         count = count +1
         end
        end
            if p count%2 != 0 || count == 1
            return seq[j]
            end
     end

end
