root = exports ? this

is_commenting = false

is_not_multiline_comment = (line) ->
  comment_token = '\#\#\#'
  comment_place = line.search comment_token

  while comment_place >= 0
    line = line.substring (comment_place + 3)
    is_commenting = not is_commenting
    comment_place = line.search comment_token

  has_code = line.search(/[\w]+/) >= 0

  is_multiline_comment = (not has_code and not is_commenting) or is_commenting
  not is_multiline_comment

count = (source) ->
  lines = source.split /[\n]/
  lines = (line for line in lines when line.search(/[\w]+/) >= 0)
  lines = (line for line in lines when is_not_multiline_comment(line))
  lines = (line for line in lines when line.search(/^[\s]*\#/) < 0)
  lines.length

root.count = count

