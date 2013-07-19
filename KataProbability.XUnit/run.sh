cp lib/xunit/xunit.dll bin
c:/Windows/Microsoft.NET/Framework64/v4.0.30319/csc.exe /target:library /out:bin/kata.dll /lib:lib /recurse:*.cs /reference:bin/xunit.dll
lib/xunit/xunit.console.clr4.exe bin/kata.dll

