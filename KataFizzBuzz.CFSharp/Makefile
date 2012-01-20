OUT=Kata.dll
MOD=Kata.netmodule

MSPEC=Machine.Specifications.dll
MTOOL=lib/mspec.exe

clean:
	rm -rf bin
	mkdir -p bin

run:	clean
	fsc --out:bin/$(MOD) --target:module --lib:lib src/*.fs
	dmcs -out:bin/$(OUT) -t:library -lib:lib -addmodule:bin/$(MOD) -r:Machine.Specifications.dll -r:FSharp.Core.dll src/*.cs
	cp lib/$(MSPEC) bin

test:	run
	mono $(MTOOL) bin/$(OUT)

