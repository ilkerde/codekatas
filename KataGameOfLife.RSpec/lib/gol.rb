class Gol
  def spin world
    x = 0
    y = 0
    n = 0

    (x..x+1).each do |nx|
      (y..y+1).each do |ny|
        n += world[nx][ny]
      end
    end

    world[x][y] = 1 if n == 3

    world
  end
end
