# a bunch of elements strung together, not in an array
#  like a game of telephone, all linked together
# recursion could be involved
# use it like an array
#  find elements in it (by position) list[5]
#  add elements at the end
#  remove any element (by position)

require 'list'

describe LinkedList do

  it "can add and then find one element" do
    list = LinkedList.new
    list.add("a")
    expect(list.get(0)).to eq "a"
  end

  it "returns nil if you try to access something beyond the list length" do
    list = LinkedList.new
    list.add("a")
    expect(list.get(5)).to eq nil
  end

  context "can find out the length of the list" do
    it "works when there are no nodes" do
      list = LinkedList.new
      expect(list.length).to eq 0
    end

    it "works when there is one node" do
      list = LinkedList.new
      list.add("a")
      expect(list.length).to eq 1
    end

    it "works when there are two nodes" do
      list = LinkedList.new
      list.add("a")
      list.add("a")
      expect(list.length).to eq 2
    end
  end

  context "when I insert two elements" do

      it "then I can find the first one" do
      list = LinkedList.new
      list.add("first")
      list.add("second")
      expect(list.get(0)).to eq "first"
    end



    it "can find the second one" do
      list = LinkedList.new
      list.add("first")
      list.add("second")
      expect(list.get(1)).to eq "second"
    end

  end
end
