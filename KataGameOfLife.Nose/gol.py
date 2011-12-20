class Gol:
  def generate(self, cell):
    return cell.next_generation()

class Cell:
  def __init__(self, neighbors=[]):
    self.neighbors = neighbors

  def is_alive(self):
    return len(self.neighbors) == 3

  def next_generation(self):
    return self
