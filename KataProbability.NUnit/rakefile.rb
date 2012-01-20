require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.cs"
binary = File.join $ME, "bin/Kata.dll"

bindir = File.join $ME, "bin"
libdir = File.join $ME, "lib"

nunitlib = File.join $ME, "lib/nunit/lib/nunit.framework.dll"
nunittool = File.join $ME, "lib/nunit/tools/nunit-console.exe"

desc "clean"
task :clean do
    FileUtils.rm_f binary
    FileUtils.mkdir_p bindir unless FileTest.directory? bindir
end

desc "build"
task :build => [:clean] do
    FileUtils.cp nunitlib, File.join(File.dirname(binary), File.basename(nunitlib))
    system "gmcs /t:library /out:#{binary} /r:#{nunitlib} /nologo /debug /recurse:#{source}"
end

desc "test"
task :test => [:build] do
     system "mono #{nunittool} #{binary}"
end
