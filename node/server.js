var express    = require("express");
var mysql      = require('mysql');
var connection = mysql.createConnection({
   host     : 'cainafricadb.db.11956473.hostedresource.com',
   user     : 'cainafricadb',
   password : 'Cainwebdev@2016',
   database : 'cainafricadb'
 });
var app = express();
 

app.listen(process.env.PORT);