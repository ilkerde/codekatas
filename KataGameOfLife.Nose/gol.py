class Gol:
  _cells = {}
 
  def set_cell(self, pos, alive=True):
    vicinity = [
      (pos[0]-1,pos[1]),
      (pos[0]+1,pos[1]),
      (pos[0],pos[1]-1),
      (pos[0],pos[1]+1)]
    cell = Cell(is_alive=alive)
    for around in vicinity:
      neighbor = self.check_cell(around)
      if neighbor is not None:
        self.neighbors(cell, neighbor)
    self._cells[pos] = cell

  def check_cell(self, pos):
    return self._cells[pos] if pos in self._cells else None

  def generate(self, cell):
    return cell.next_generation()

  def neighbors(self, a_cell, b_cell):
    a_cell.neighbors.append(b_cell)
    b_cell.neighbors.append(a_cell)

class Cell:
  def __init__(self, neighbors=[], is_alive=False):
    self.neighbors = list(set(neighbors))
    self.is_alive = is_alive

  def next_generation(self):
    alive_neighbors = filter(lambda n: n.is_alive, self.neighbors)
    will_be_filled = len(alive_neighbors) == 3 or (self.is_alive and len(alive_neighbors) == 2)
    return Cell(self.neighbors, will_be_filled)

