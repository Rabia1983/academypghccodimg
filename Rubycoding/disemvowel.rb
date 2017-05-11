def disemvowel(str)
str1=""
  for i in (0..str.length-1)
  if str[i] != "a" && str[i] != "e" && str[i] != "i" && str[i] != "o" && str[i] != "u" && str[i] != "A" && str[i] != "E" && str[i] != "I" &&str[i] != "O" &&str[i] != "U"
  str1 << str[i]
  end
  end
  return str1
end
