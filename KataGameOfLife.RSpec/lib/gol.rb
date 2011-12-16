class Gol
  def spin world
    newworld = world

    mx = world.length
    my = world[0].length

    (0..mx).each do |x|
      (0..my).each do |y|
        n = count_neighbors world, x, y, mx, my
        newworld[x][y] = 1 if n == 3
      end
    end

    newworld
  end

  private 

  def count_neighbors world, x, y, mx, my
    lox = x-1 < 0 && 0 || x-1
    loy = y-1 < 0 && 0 || y-1
    hix = x+1 >= mx && mx-1 || x+1
    hiy = y+1 >= my && my-1 || y+1

    n = 0
    
    (lox..hix).each do |nx|
      (loy..hiy).each do |ny|
        n += world[nx][ny] 
      end
    end

    n
  end

end
