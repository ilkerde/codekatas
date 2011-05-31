def replacer text, placeholders={}
  placeholders.each do |key,value|
    text.gsub! "$#{key}$", value
  end
  if (text =~ /\$.*?\$/)
    text.gsub! /\$.*?\$/, ""
  end
  text
end
