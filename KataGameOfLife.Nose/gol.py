class Gol:
  def generate(self, cell):
    return cell.next_generation()

class Cell:
  def __init__(self, neighbors=[], is_alive=False):
    self.neighbors = neighbors
    self.is_alive = is_alive

  def next_generation(self):
    alive_neighbors = filter(lambda n: n.is_alive, self.neighbors)
    will_be_alive = len(alive_neighbors) == 3
    return Cell(self.neighbors, will_be_alive)
