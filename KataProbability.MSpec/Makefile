OUT=Kata.dll

MSPEC=Machine.Specifications.dll
MTOOL=lib/mspec.exe

clean:
	rm -rf bin
	mkdir -p bin

run:	clean
	dmcs -out:bin/$(OUT) -t:library -lib:lib -r:$(MSPEC) src/*.cs
	cp lib/$(MSPEC) bin

test:	run
	mono $(MTOOL) bin/$(OUT)

