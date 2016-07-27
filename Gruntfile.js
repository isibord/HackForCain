module.exports = function (grunt) {
  grunt.initConfig({
    execute: {
      target: {
        src: ['node/server.js']
      }
    },
    watch: {
      scripts: {
        files: ['node/server.js'],
        tasks: ['execute'],
      },
    }
  });

  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-execute');
};