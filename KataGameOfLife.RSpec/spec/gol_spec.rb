require 'gol'

describe "three neighbors bring life" do
  describe "when empty upper left corner has three neighbors" do
    world = [ 
      [0,1,0],
      [1,1,0],
      [0,0,0]
    ]

    it "should bring life to upper left corner" do
      Gol.new.spin(world)[0][0].should == 1
    end
  end
end
