. .\template.ps1

template "" | should be_equal ""
template "anything" | should be_equal "anything"
