// Karma configuration
// Generated on Wed Sep 18 2013 08:04:02 GMT+0200 (CEST)

module.exports = function (config) {
  'use strict';

  config.set({
    basePath: '',
    frameworks: ['jasmine'],
    files: [
      'test/phantom-polyfill.js',
      'test/jasmine-aliases.js',
      'src/**/*.js',
      'test/**/*.js',
      'src/**/*.coffee',
      'test/**/*.coffee'
    ],
    exclude: [],
    reporters: ['spec'],
    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ['PhantomJS'],
    captureTimeout: 60000,
    singleRun: false,

    preprocessors: {
      'src/**/*.js': ['6to5'],
      'test/**/*.js': ['6to5'],
      'src/**/*.coffee': ['coffee'],
      'test/**/*.coffee': ['coffee']
    },

    '6to5Preprocessor': {
      options: {
        sourceMap: 'inline'
      },
      filename: function(file) {
        return file.originalPath.replace(/\.js$/, '.es5.js');
      },
      sourceFileName: function(file) {
        return file.originalPath;
      }
    },

    'coffeePreprocessor': {
      options: {
        sourceMap: true
      },
      transformPath: function(path) {
        return path.replace(/\.coffee$/, '.js');
      }
    }
  });
};
