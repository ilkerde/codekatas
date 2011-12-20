from gol import *

class test_repopulation_rule:
  gol = Gol()

  def when_empty_cell_has_three_neighbors_then_cell_gets_populated_test(self):
    neighbors = [Cell(), Cell(), Cell()]
    cell = Cell(neighbors)
    new_cell = self.gol.generate(cell)
    assert new_cell.is_alive()

  def when_empty_cell_has_three_neighbors_its_just_empty_test(self):
    neighbors = [Cell(), Cell(), Cell()]
    cell = Cell(neighbors)
    assert not cell.is_alive()

  def when_empty_cell_has_no_neighbors_then_cell_stays_empty_test(self):
    cell = Cell()
    new_cell = self.gol.generate(cell)
    assert not new_cell.is_alive()
