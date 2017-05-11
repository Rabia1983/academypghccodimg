def longest_consec(strarr, k)
 leng={}

n=strarr.length
result = ""
if n==0 || k>n || k<=0
return ""
else
la=[]
strarr.each do |word|
p la << word.length
end
puts k
 hashy = Hash[strarr.zip la]
 p hashy= hashy.sort{|a1,a2| a2[1]<=>a1[1]}
 i=1
 hashy.each do |key,value|
 if value > k && i<=k
  result << key
  i=i+1
 end
 end
 end

return result
end
