class String
  def wrap linesize
    return self if self.size <= linesize

    last_space = self.rindex ' ', linesize
    unless last_space.nil? 
      return self[0, last_space] + "\n" + self[last_space + 1, self.size].wrap(linesize)
    end

    return self[0, linesize] + "\n" + self[linesize, self.size].wrap(linesize)
  end
end
