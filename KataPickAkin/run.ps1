properties {
	$srcpath = gi ./source;
	$binpath = gi ./bin;
	
	$config = "debug";

	$assembly = "pickakin.dll";

	$outpath = join-path $binpath $config;
	$outdll = join-path $outpath $assembly;

	$testfx = gi ./packages/Machine.Specifications.0.4.10.0/lib/Machine.Specifications.dll;
	$testrunner = "./packages/Machine.Specifications.0.4.10.0/tools/mspec.exe";

	$specspath = gi ./specs;
	$specsoutdll = join-path $outpath "specs.$assembly";
}

task default -depends build;

task clean {
	rm -r -for $outpath;
	mkdir $outpath | out-null;
}

task build -depends clean {
	exec { csc /out:$outdll /target:library (join-path $srcpath "*.cs") }
}

task specs -depends build {
	cp -for $testfx $outpath;
	exec { csc /out:$specsoutdll /reference:$testfx /reference:$outdll /target:library (join-path $specspath "*.cs") }
}

task test -depends specs {
	exec { . $testrunner $specsoutdll }
}
