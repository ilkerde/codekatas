require 'fileutils'

$ME = File.dirname __FILE__
$HOME = ENV['HOME']

source = File.join $ME, "*.vala"
binary = File.join $ME, "fizzbuzz"

desc "clean"
task :clean do
  FileUtils.rm_f binary
end

desc "build"
task :build => [:clean] do
  %x[ valac --pkg gee-1.0 #{source} -o #{binary} ]
end

desc "test"
task :test => [:build] do
  %x[ #{binary} test ]
end
