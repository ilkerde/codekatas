class Gol:
  _cells = {}
 
  def free_cell(self, pos):
    self._cells[pos] = Cell()

  def full_cell(self, pos):
    xb_cell = self.check_cell((pos[0]-1,pos[1]))
    xa_cell = self.check_cell((pos[0]+1,pos[1]))
    yb_cell = self.check_cell((pos[0],pos[1]-1))
    cell = Cell(is_alive=True)
    if xb_cell is not None:
      self.neighbors(cell, xb_cell)
    if xa_cell is not None:
      self.neighbors(cell, xa_cell)
    if yb_cell is not None:
      self.neighbors(cell, yb_cell)
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

