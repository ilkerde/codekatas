OUT=Kata.dll

TESTLIB=xunit.dll
TESTRUN=lib/xunit.console.clr4.exe

clean:
	rm -rf bin
	mkdir -p bin

run:	clean
	fsc -o:bin/$(OUT) -a -I:lib -r:lib/$(TESTLIB) src/*.fs
	cp lib/$(TESTLIB) bin
	cp lib/FSharp.Core.dll bin

test:	
	mono $(TESTRUN) bin/$(OUT)

