var express = require('express');
var app = express();

var PORT = 3000;
app.locals.basedir = __dirname;

app.use('/data',express.static('data'));
app.use('/public', express.static('public'));

app.set('view engine','pug');

app.get('/', function(req,res) {
    res.render('index', {title: 'Express Dataset Api', label: 'Express Datasets'});
});


app.listen(PORT, function() {
    console.log('Dataset Api listening on port '+PORT);
});
