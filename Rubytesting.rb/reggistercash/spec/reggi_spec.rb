require "reggi"

describe Reggister do

    describe ".reggi" do
        context "given the number" do
            it "return twenties " do
              try = Reggister.new
              expect(try.get_x(75)).to match_array([3, "twenties", 1, "tens", 5, "single"])
            end
        end
end
end

=begin ...... group work
require 'program'



describe CashRegister do

  describe "makechange" do

    context "given 1.00" do

      it "returns 1 dollar" do

        change = CashRegister.new

        expect(change.makechange(1.00)).to eql("1 single")

      end

    end



      describe "makechange" do

        context "given .26" do

          it "returns 1 quarter 1 pennies" do

            change = CashRegister.new

            expect(change.makechange(0.26)).to eql("1 quarters, 1 pennies")

    end

  end

  describe "makechange" do

    context "given 5.79" do

      it "returns 1 fives, 3 quarters, 4 pennies" do

        change = CashRegister.new

        expect(change.makechange(5.79)).to eql("1 fives, 3 quarters, 4 pennies")

end

end



end

end

end

end
=end
