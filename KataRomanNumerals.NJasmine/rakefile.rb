require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.cs"
binary = File.join $ME, "bin/RomanNumbers.dll"

njasmine = File.join $ME, "lib/njasmine/NJasmine.dll"
powerass = File.join $ME, "lib/njasmine/PowerAssert.dll"
nunitlib = File.join $ME, "lib/njasmine/nunit.framework.dll"
nunitrun = File.join $ME, "lib/njasmine/nunit/nunit-console.exe"

desc "clean"
task :clean do
    FileUtils.rm_f binary
    FileUtils.mkdir File.dirname binary unless File.directory? File.dirname binary
end

desc "build"
task :build => [:clean] do
    FileUtils.cp njasmine, File.join(File.dirname(binary), File.basename(njasmine))
    FileUtils.cp powerass, File.join(File.dirname(binary), File.basename(powerass))
    FileUtils.cp nunitlib, File.join(File.dirname(binary), File.basename(nunitlib))
    system "csc /t:library /out:#{binary} /r:#{njasmine} /r:#{powerass} /r:#{nunitlib} /nologo /debug /recurse:#{source}"
end

desc "test"
task :test => [:build] do
    system "#{nunitrun} #{binary}"
end
