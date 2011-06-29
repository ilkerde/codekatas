class String
  def wrap linesize
    return self if self.size < linesize
    self.insert linesize, "\n"  
  end
end
