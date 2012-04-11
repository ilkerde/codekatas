root = exports ? this

count = (source) ->
  lines = source.split /[\n]/
  lines.length

root.count = count

