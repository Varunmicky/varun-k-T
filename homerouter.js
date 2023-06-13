const express = require('express');
const Router = express.Router();
const usersCollection = require('../modules/userdata')
const bookingData = require('../modules/bookingdata')

Router.get('/index',(req,res)=>{
    res.render('index',{title:"", password:"",email:""})
})

Router.get('/register',(err,res)=>{
    res.render('register',{title:"Welcome", password:"",email:""})
})

Router.post('/register',async(req,res)=>{
    try{
        const {
            name,
            email,
            password,
            cpassword
        } = req.body; 
       
        if(password === cpassword){

            const req_userdata = new usersCollection({
                name,
                email,
                password
            })
            req_userdata.save(err=>{
                if(err){
                    console.log('Error')
                }else{
                    res.render('register',{title:"Register Done", password:"",email:""})
                }
            })
            const usermail = await usersCollection.findOne({email:email});
            if(email === usermail.email){
                res.render('register',{title:"", password:"",email:"Email already exist"})
            }else{
                console.log('Err')
            }
        


        }else{
            res.render('register',{title:"", password:"Password Not Matching",email:""})
        }
    

    }catch(error){
        res.render('register',{title:"Error", password:"",email:""});

    }
})



Router.get('/login',(req,res)=>{
    res.render('login',{title:"", password:"",email:""})
})

Router.post('/login',(req,res)=>{
    const {
        email,
        password
    } = req.body;

    usersCollection.findOne({email:email},(err,result)=>{
        if(email === result.email && password === result.password){
            res.render('index',{title:"", password:"",email:""})
        
           
        }else{
            res.render('login',{title:"Please! Enter Valid Informations", password:"",email:""})
        }
        

    })
    
})




Router.get('/booking',(req,res)=>{
    res.render('booking',{title:"", password:"",email:""})
})

Router.post('/booking', async(req,res)=>{
    try{
        const{
            name,
            email,
            contact,
            event,
            package,
            date,
            end_date,
            start_time,
            end_time,
            pincode,
            primary_address,
            area,
            landmark,
            town_city,
            state
        } = req.body;

       const req_bookingdata = new bookingData({

            name,
            email,
            contact,
            event,
            package,
            date,
            end_date,
            start_time,
            end_time,
            pincode,
            primary_address,
            area,
            landmark,
            town_city,
            state

       })
       req_bookingdata.save(err=>{
        if(err){
            console.log("Error");
        }else{
            res.render('booking',{title:"your booking was confrimed", password:"",email:""});
        }
       });

    }catch(error){
        res.render('booking',{title:"", password:"",email:""});

    }
})




module.exports = Router;