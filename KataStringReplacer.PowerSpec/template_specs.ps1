. .\template.ps1

template "" | should be_equal ""
template "anything" | should be_equal "anything"
template "say %what%" @{"what"="hi"} | should be_equal "say hi"
template "say %what%" @{"msg"="hi"} | should be_equal "say "
