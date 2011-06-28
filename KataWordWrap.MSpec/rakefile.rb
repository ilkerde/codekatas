require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.cs"
binary = File.join $ME, "bin/WordWrap.dll"

testlib = (Dir.glob File.join($ME, "**/lib/Machine.Specifications.dll")).first
testrun = (Dir.glob File.join($ME, "**/mspec-clr4.exe")).first

desc "clean"
task :clean do
    FileUtils.rm_f binary
end

desc "build"
task :build => [:clean] do
    FileUtils.cp testlib, File.join(File.dirname(binary), File.basename(testlib))
    system "csc /t:library /out:#{binary} /r:#{testlib} /nologo /debug /recurse:#{source}"
end

desc "test"
task :test => [:build] do
    system "#{testrun} #{binary}"
end
