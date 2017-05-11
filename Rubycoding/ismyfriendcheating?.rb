def removNb(n)
arr1=[]
    arr=[]
    sum=0
    for i in (1..n)
    sum=sum+i
    end
    for i in (1..n)
      for j in (1..n)
       if i*j == sum - (i+j)
     p  arr << [i,j].to_a
      end
      end
      end

    return arr
end
