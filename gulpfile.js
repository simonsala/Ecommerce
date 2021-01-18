const { src, dest, watch, series } = require('gulp');
const sass = require('gulp-sass');
const del = require('del');
const sourcemaps = require('gulp-sourcemaps');
sass.compiler = require('node-sass');

function compileSass() {
    return src(['SASS/*.sass'])
        .pipe(sourcemaps.init())
        .pipe(sass({ includePaths: ['node_modules/boostrap/scss/'] }).on('error', sass.logError))
        .pipe(sourcemaps.write('.'))
        .pipe(dest('wwwroot/css'))
}

async function cleanCss() {
    await del(['./wwwroot/css/*.css']);
}

function watchSass() {
    return watch(['SASS/*.sass', 'node_modules/boostrap/scss/**/*.scss'], series(cleanCss, compileSass));
}

exports.default = series(cleanCss, compileSass, watchSass);

