OUT=Kata.dll
FOUT=Kata.FSharp.dll

MSPEC=Machine.Specifications.dll
MTOOL=lib/mspec.exe

clean:
	rm -rf bin
	mkdir -p bin

run:	clean
	fsc -o:bin/$(FOUT) --target:library -I:lib src/*.fs
	dmcs -out:bin/$(OUT) -t:library -lib:lib -r:bin/$(FOUT) -r:Machine.Specifications.dll -r:FSharp.Core.dll src/*.cs
	cp lib/$(MSPEC) bin
	cp lib/FSharp.Core.dll bin

test:	run
	mono $(MTOOL) bin/$(OUT)

