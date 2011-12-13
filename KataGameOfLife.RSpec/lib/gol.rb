class Gol
  def spin world
    x = 0
    y = 0

    n1 = world[x+1][y]
    n2 = world[x+1][y+1]
    n3 = world[x][y+1]

    n = n1+n2+n3
    world[x][y] = 1 if n == 3

    world
  end
end
