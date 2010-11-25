$projects = ls ..\ *.csproj;
$projects | %{ msbuild $_.fullname };