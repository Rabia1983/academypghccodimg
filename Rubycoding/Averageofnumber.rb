def averages(arr)

  arr1=[]
  for i in(0..arr.length-2)
  avv= (arr[i].to_i+arr[i+1].to_i)/2.to_f
  arr1 << avv
  end
  return arr1
end
