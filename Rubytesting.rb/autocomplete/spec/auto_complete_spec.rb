require 'auto_complete'

describe Auto_complete do
    describe 'find_matches' do
        context "when given 'hero'" do
            it "returns 'hero'" do
                ac = Auto_complete.new
                expect(ac.find_matches('hero')).to match_array(['hero'])
            end
        end

        context "when given 'ca'" do
            it "returns 'car', cab" do
                ac = Auto_complete.new
                expect(ac.find_matches('ca')).to match_array(['car','cab'])
            end
        end

        context "when given 'ma'" do
            it "returns 'man', 'mane', 'married'" do
                ac = Auto_complete.new
                expect(ac.find_matches('ma')).to match_array(['man','mane','married'])
            end
        end

        describe 'find_exact_match' do
            context "when given 'hello'" do
            it "returns 'we found a match'" do
                ac = Auto_complete.new
                expect(ac.find_exact_match('hello')).to eql("we found a match: hello")
            end
        end
      end
    end
  end
