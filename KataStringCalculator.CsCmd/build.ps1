	rm -r -for bin > $null
	mkdir -p bin > $null

	C:\Windows\Microsoft.NET\Framework\v3.5\csc -out:bin\Kata.dll -t:library -lib:lib -r:Machine.Specifications.dll src\*.cs -nologo
	cp lib\Machine.Specifications.dll bin > $null

	lib\mspec.exe bin\Kata.dll

