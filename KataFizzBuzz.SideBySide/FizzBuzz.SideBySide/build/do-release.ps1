function get-releaseprojectname($project=$null)
{
	return join-path $project.directoryname ($project.basename + ".release.csproj");
}

function new-releaseproject($project=$null)
{
	$releaseprojectname = get-releaseprojectname -project $project;
	
	$projectxml = [xml](cat $project.fullname);
	$projectxml.selectnodes('//*[local-name() = "Reference"][@Include = "xunit"]') | %{ $_.parentnode.removechild($_) } | out-null;
	$projectxml.selectnodes('//*[local-name() = "Compile"][contains(@Include, "Tests.cs")]') | %{ $_.parentnode.removechild($_) } | out-null;
	$projectxml.save($releaseprojectname);
	
	return $releaseprojectname;
}

function test-get-releaseprojectname-returns-fizzbuzz-sidebyside-release-csproj()
{
	$project = gi ..\FizzBuzz.SideBySide.csproj;
	
	$releaseproject = get-releaseprojectname -project $project;
	$releaseprojectfileinfo = new-object system.io.fileinfo $releaseproject;
	
	if ($releaseprojectfileinfo.name -ne "FizzBuzz.SideBySide.release.csproj") { throw "release name expected."; };
}

function test-new-releaseproject-copies-original-csproj-file-as-release-csproj-file()
{
	$project = gi ..\FizzBuzz.SideBySide.csproj;

	$releaseproject = new-releaseproject -project $project;
	
	if (!(test-path $releaseproject)) { throw "release project file copy expected."; };
	rm -for $releaseproject;
}

function test-new-releaseproject-removes-xunit-reference-from-project-file()
{
	$project = gi ..\FizzBuzz.SideBySide.csproj;

	$releaseproject = new-releaseproject -project $project;

	$releaseprojectxml = [xml](cat $releaseproject);
	$xunitreferenceelements = $releaseprojectxml.selectnodes('//*[local-name() = "Reference"][@Include = "xunit"]');
	
	if ($xunitreferenceelements.count -ne 0) { throw "no xunit references in release project file expected."; };
	rm -for $releaseproject;
}

function test-new-releaseproject-removes-all-source-code-files-ending-with-tests-cs-from-project-file()
{
	$project = gi ..\FizzBuzz.SideBySide.csproj;

	$releaseproject = new-releaseproject -project $project;

	$releaseprojectxml = [xml](cat $releaseproject);
	$testcsfileelements = $releaseprojectxml.selectnodes('//*[local-name() = "Compile"][contains(@Include, "Tests.cs")]');
	
	if ($testcsfileelements.count -ne 0) { throw "no *Tests.cs files in release project file expected."; };
	rm -for $releaseproject;
}

function build-releaseproject($project=$null)
{
	$releaseproject = new-releaseproject $project;
	msbuild $releaseproject /p:Configuration=Release
}

# ### release build script ###

$runmode = $true;

if ($runmode)
{
	rm *.release.csproj;
	ls *.csproj | %{ build-releaseproject $_ };
	rm *.release.csproj;
}
else
{
	test-get-releaseprojectname-returns-fizzbuzz-sidebyside-release-csproj;
	test-new-releaseproject-copies-original-csproj-file-as-release-csproj-file;
	test-new-releaseproject-removes-xunit-reference-from-project-file;
	test-new-releaseproject-removes-all-source-code-files-ending-with-tests-cs-from-project-file;
}
