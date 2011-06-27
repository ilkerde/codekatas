require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.cs"
binary = File.join $ME, "bin/WordWrap.dll"

nunitlib = File.join $ME, "lib/nunit/framework/nunit.framework.dll"
nunitrun = File.join $ME, "lib/nunit/nunit-console.exe"
desc "clean"
task :clean do
    FileUtils.rm_f binary
end

desc "build"
task :build => [:clean] do
    FileUtils.cp nunitlib, File.join(File.dirname(binary), File.basename(nunitlib))
    system "csc /t:library /out:#{binary} /r:#{nunitlib} /nologo /debug /recurse:#{source}"
end

desc "test"
task :test => [:build] do
    system "#{nunitrun} #{binary}"
end
