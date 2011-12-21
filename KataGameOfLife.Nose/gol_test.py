from gol import *

class test_repopulation_rule:
  gol = Gol()

  def when_empty_cell_has_three_alive_neighbors_then_cell_gets_populated_test(self):
    alive_cell = Cell(is_alive=True)
    neighbors = [alive_cell, alive_cell, alive_cell]
    cell = Cell(neighbors)
    new_cell = self.gol.generate(cell)
    assert new_cell.is_alive

  def when_empty_cell_has_three_neighbors_its_just_empty_test(self):
    alive_cell = Cell(is_alive=True)
    neighbors = [alive_cell, alive_cell, alive_cell]
    cell = Cell(neighbors)
    assert not cell.is_alive

  def when_empty_cell_has_no_neighbors_then_cell_stays_empty_test(self):
    cell = Cell()
    new_cell = self.gol.generate(cell)
    assert not new_cell.is_alive

  def when_empty_cell_has_three_empty_neighbors_then_cell_stays_empty_test(self):
    neighbors = [Cell(), Cell(), Cell()]
    cell = Cell(neighbors)
    new_cell = self.gol.generate(cell)
    assert not new_cell.is_alive

class test_neighbor_uniqueness:
  def when_cell_already_has_same_cell_as_neighbor_then_may_not_accept_that_cell_as_neighbor_test(self):
    a_cell = Cell()
    cell = Cell([a_cell, a_cell])
    assert len(cell.neighbors) == 1

