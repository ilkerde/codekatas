class String
  def wrap linesize
    return self if self.size < linesize

    last_space = self.rindex ' ', linesize
    unless last_space.nil? 
      self[last_space] = "\n"
      return self
    end

    self.insert linesize, "\n" 
  end
end
