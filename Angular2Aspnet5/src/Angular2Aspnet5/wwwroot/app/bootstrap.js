var angular2_1 = require('angular2/angular2');
var app_1 = require('./app');
angular2_1.bootstrap(app_1.App)
    .catch(function (err) { return console.error(err); });
