class Gol
  def spin world
    newworld = world

    mx = world.length
    my = world[0].length

    (0..mx).each do |x|
      (0..my).each do |y|
        lox = x-1
        loy = y-1
        hix = x+1
        hiy = x+1

        hix = world.length - 1 if hix >= world.length
        hiy = world[hix].length - 1 if hiy >= world[hix].length
        lox = 0 if lox < 0
        loy = 0 if loy < 0

        n = 0
        
        (lox..hix).each do |nx|
          (loy..hiy).each do |ny|
            n += world[nx][ny]
          end
        end

        newworld[x][y] = 1 if n == 3
      end
    end

    newworld
  end
end
