const express = require("express");
const app = express();
const mysql = require("mysql2");
const cors = require("cors");
const bodyparser = require("body-parser");

const db = mysql.createPool({

    host:"localhost",
    user:"root",
    password:"root123",
    database:"abhi"
});


app.use(cors());
app.use(express.json());
app.use(bodyparser.json());
// app.use(bodyparser.urlencoded({extension:false}));


app.get("/",(req,resp)=>{

    const details = "SELECT * FROM trainer";

    db.query(details,(err,result)=>{
        if(err){
            console.log(err)
            return;
        }

        resp.send(result)
    });


})


app.post("/insert",(req,resp)=>{

    const data = "INSERT INTO trainer (trainer_id,name,address,gender,skill,qualification,contact,doj) values(?,?,?,?,?,?,?,?)";

    db.query(data,[req.body.trainer_id,req.body.name,req.body.address,req.body.gender,req.body.skill,
        req.body.qualification,req.body.contact,req.body.doj],(err,result)=>{
        if(err){
            console.log( err)
            return;
        }

        resp.send(result);
        resp.send("Record inserted succesfully")
    });


})

app.listen(4000);
console.log("server is running on 4000");