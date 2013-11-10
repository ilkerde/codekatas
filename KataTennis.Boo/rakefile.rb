require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.boo"
binary = File.join $ME, "bin/Kata.dll"

bindir = File.join $ME, "bin"
libdir = File.join $ME, "lib"

nunitlib = File.join $ME, "lib/nunit/nunit.framework.dll"

desc "clean"
task :clean do
    FileUtils.rm_f binary
    FileUtils.mkdir_p bindir unless FileTest.directory? bindir
end

desc "build"
task :build => [:clean] do
    FileUtils.cp nunitlib, File.join(File.dirname(binary), File.basename(nunitlib))
    system "booc -t:library -o:#{binary} -r:#{nunitlib} -nologo -debug #{source}"
end

desc "test"
task :test => [:build] do
     system "nunit-console #{binary}"
end
