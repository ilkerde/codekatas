function template($text, $tokens = @{}) {
  $tokens.getenumerator() | %{
    $key = $_.key
    $value = $_.value
    $text = $text.replace("%$key%", "$value")
  }
  $text
}
