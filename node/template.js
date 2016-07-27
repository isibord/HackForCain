var express    = require("express");
 var mysql      = require('mysql');
 var connection = mysql.createConnection({
   host     : 'XXXX',
   user     : 'XXXX',
   password : 'XXXX',
   database : 'XXXX'
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
 connection.query('SELECT title, firstname, lastname, email_address, phone, role_name, address, \
  city, state, country, company, date_of_first_contact \
  FROM people p join role r on p.role_id = r.id', function(err, rows, fields) {
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