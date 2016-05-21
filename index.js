var express = require('express');
var app = express();

var PORT = 3000;

app.use('/data',express.static('data'));

app.get('/', function(req,res) {
    res.send('Hello World!');
});


app.listen(PORT, function() {
    console.log('Dataset Api listening on port '+PORT);
});
