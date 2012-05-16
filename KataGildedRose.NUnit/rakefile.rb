require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.cs"
binary = "bin/Kata.dll"

bindir = File.join $ME, "bin"
libdir = File.join $ME, "lib"

nunitlib = "lib/nunit/lib/nunit.framework.dll"
nunittool = "lib/nunit/tools/nunit-console.exe"

desc "clean"
task :clean do
    FileUtils.rm_f binary
    FileUtils.mkdir_p bindir unless FileTest.directory? bindir
end

desc "build"
task :build => [:clean] do
    FileUtils.cp nunitlib, File.join(File.dirname(binary), File.basename(nunitlib))
    source = Dir.glob(source).map {|f| File.basename(f)}
    source = source.join ' '
    system "gmcs /t:library /out:#{binary} /r:#{nunitlib} /nologo /debug #{source}"
end

desc "test"
task :test => [:build] do
     system "mono #{nunittool} #{binary}"
end
