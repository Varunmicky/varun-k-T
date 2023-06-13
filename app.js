const express = require('express');
const mongoose = require('mongoose');
const bodyparser = require('body-parser');
const homerouter = require('./routers/homerouter');
const port = process.env.port || 3001;

const app = express();

    // Database Connection

    mongoose.connect('mongodb://localhost:27017/userdata')
    .then(()=>{console.log('Mongoose Connection Successfully')})
    .catch((err)=>{console.log(err)})


app.set('view engine','ejs')
app.use(express.static(__dirname+'/public'));
app.use(express.static(__dirname+'/js'));


app.use(bodyparser.urlencoded({ extended:false}))

app.use(bodyparser.json())

app.use('/',homerouter);


app.listen(port,()=>{
    console.log(`listening on port ${port}`)
})