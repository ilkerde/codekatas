class Gol
  def spin world
    mx = world.length-1
    my = world[0].length-1

    newworld = []
    (0..mx).each do |x|
      newland = []
      (0..my).each do |y|
        n = count_neighbors world, x, y, mx, my
        citizen = n == 3 && 1 || world[x][y]
        citizen = (
          n > 3 ||
          n == 1
        ) && 0 || citizen
        newland << citizen
      end
      newworld << newland
    end

    newworld
  end

  private 

  def count_neighbors world, x, y, mx, my
    lox = x-1 < 0 && 0 || x-1
    loy = y-1 < 0 && 0 || y-1
    hix = x+1 >= mx && mx || x+1
    hiy = y+1 >= my && my || y+1

    n = -world[x][y]
    
    (lox..hix).each do |nx|
      (loy..hiy).each do |ny|
        n += world[nx][ny] 
      end
    end

    n
  end

end
