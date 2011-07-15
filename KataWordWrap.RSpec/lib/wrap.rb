class String
  def wrap linesize
    return self if self.size <= linesize

    last_space = self.rindex ' ', linesize 
    break_left = last_space || linesize
    break_right = break_left + (last_space.nil?? 0:1)

    self[0, break_left] + "\n" + self[break_right, self.size].wrap(linesize)
  end
end
