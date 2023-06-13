
const mongoose = require('mongoose');

const shema2 = new mongoose.Schema({

    name:{
        type:String,
        required:true,
        lowercase:true
    },
    email:{
        type:String,
        required:true
    },
    contact:{
        type:Number,
        required:true
    },
    event:{
        type:String,
        required:true
    },
    package:{
        type:String,
        required:true,
    },
    date:{
        type:Date,
        required:true
    },
    end_date:{
        type:Date,
        required:true
    },
    start_time:{
        type:String,
        required:true
    },
    end_time:{
        type:String,
        required:true
    },
    pincode:{
        type:Number,
        required:true
    },
    primary_address:{
        type:String,
        required:true,
        lowercase:true
    },
    area:{
        type:String,
        required:true,
        lowercase:true
    },
    landmark:{
        type:String,
        required:true
    },
    town_city:{
        type:String,
        required:true    
    },
    state:{
        type:String,
        required:true
    },
    

})


const bookingData = new mongoose.model('bookingData',shema2);
module.exports = bookingData;