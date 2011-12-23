class Gol:
  def generate(self, cell):
    return cell.next_generation()

class Cell:
  def __init__(self, neighbors=[], is_alive=False):
    self.neighbors = list(set(neighbors))
    self.is_alive = is_alive

  def next_generation(self):
    alive_neighbors = filter(lambda n: n.is_alive, self.neighbors)
    will_be_filled = len(alive_neighbors) == 3 or (self.is_alive and len(alive_neighbors) == 2)
    return Cell(self.neighbors, will_be_filled)

