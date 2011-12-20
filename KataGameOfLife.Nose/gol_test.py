from gol import *

class test_repopulation_rule:
  gol = Gol()

  def when_empty_cell_has_three_neighbors_then_cell_gets_populated_test(self):
    neighbors = [Cell(), Cell(), Cell()]
    cell = Cell(neighbors)
    
    new_cell = self.gol.generate(cell)

    assert new_cell.is_alive

