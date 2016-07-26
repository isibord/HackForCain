var express    = require("express");
 var mysql      = require('mysql');
 var connection = mysql.createConnection({
   host     : 'localhost',
   port     : 0000,
   user     : 'xxxx',
   password : 'xxxx',
   database : 'xxxx'
 });
 var app = express();
 
 connection.connect(function(err){
 if(!err) {
     console.log("Database is connected ... \n\n");  
 } else {
      console.log(err);
     console.log("Error connecting database ... \n\n");  
 }
 });
 
 app.get("/",function(req,res){
 connection.query('SELECT * from role', function(err, rows, fields) {
   if (!err) {
     console.log('The solution is: ', rows);
     res.send(rows);
   }
   else {
     console.log(err);
     console.log('Error while performing Query.');
   }
   });
 connection.end(); 
 });
 app.listen(3000);