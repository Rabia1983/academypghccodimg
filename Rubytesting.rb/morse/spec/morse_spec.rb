require "morse"

describe Morse do

    describe ".morse" do
        context "given the letter a" do
            it "return .- " do
              try = Morse.new
              expect(try.to_morse("abcd")).to eql(".- -... -.-. -..")
            end
        end
end
end
