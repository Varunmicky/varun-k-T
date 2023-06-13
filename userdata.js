const mongoose = require('mongoose');

const shema = new mongoose.Schema({
    name:{
        type:String,
        required:true,
        lowercase:true
    },

    email:{
        type:String,
        required:true,
        unique:true
    },

    password:{
        type:String,
        required:true,
        password:true
    },

})

const usersCollection = new mongoose.model('usersCollection',shema);
module.exports = usersCollection;