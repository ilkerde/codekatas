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

  describe "when empty lower right corner has three neighbors" do
    world = [ 
      [0,0,0],
      [0,1,1],
      [0,1,0]
    ]

    it "should bring life to lower right corner" do
      Gol.new.spin(world)[2][2].should == 1
    end
  end

  describe "when empty upper left corner has no neighbors" do
    world = [ 
      [0,0,0],
      [0,0,0],
      [0,0,0]
    ]

    it "should stay empty" do
      Gol.new.spin(world)[0][0].should == 0
    end
  end

  describe "when empty cell have exactly three neighbors and one cell beneath with two neighbors" do
    world = [ 
      [0,0,0],
      [1,1,1],
      [0,0,0]
    ]

    it "should be that empty cell becomes alive" do
      Gol.new.spin(world)[0][1].should == 1
    end

    it "should be that cell beneath of it stays empty" do
      Gol.new.spin(world)[0][2].should == 0
    end
  end
end
