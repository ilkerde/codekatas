module("username validation");
test("no username should not indicate existance", function(){
  $("#name").val("");
  ok(validator.userNameExists() == false);
});
test("entered username should indicate existance", function(){
  $("#name").val("testuser");
  ok(validator.userNameExists() == true);
});

