def replacer template, placeholders={}
  text = template
  placeholders.each do |key,value|
    text.gsub! "$#{key}$", value
  end
  text
end
