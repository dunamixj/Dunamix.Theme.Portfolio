const sh = require('shelljs');
const upath = require('upath');

const destPath = upath.resolve(upath.dirname(__filename), '../wwwroot/Themes/Dunamix.Theme.Portfolio');

sh.rm('-rf', `${destPath}/*`)

