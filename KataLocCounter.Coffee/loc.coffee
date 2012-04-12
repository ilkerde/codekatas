root = exports ? this

count = (source) ->
  lines = source.split /[\n]/
  lines = (line for line in lines when line.search(/[\w]+/) >= 0)
  lines.length

root.count = count

