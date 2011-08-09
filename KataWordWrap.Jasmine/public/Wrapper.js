var wrap = function(text, marker){
  if (text.length < marker)
    return text;

  var lastspace = text.lastIndexOf(' ', marker);
  var wrapat = lastspace > 0 ? lastspace : marker;
  
  return text.substring(0, wrapat).trim() + '\n' + text.substring(wrapat).trim();
};
