import {Component } from '@angular/core';
import {RegisterService} from "../services/register.service";
import {FormGroup,FormBuilder,Validators} from '@angular/forms';
@Component({
selector:"app-register",
templateUrl:"./register.component.html"
})
export class RegisterComponent{
    constructor(private registerSvc:RegisterService,private fb:FormBuilder){
      this.registrationForm = this.fb.group({
        Password:[null, Validators.required],
        firstName:[null,Validators.compose([Validators.required,
          Validators.minLength(5)
        ])]
      });
    }
 user={};
 registrationForm:FormGroup;
registerSuccess:Boolean=false;
registerFailure:Boolean=false;
 registerUser(){
     this.registerSvc.registerUser(this.user);
    // this.registerSvc.registerUser(this.user)
     //.subscribe(
         //data=>{
            // console.log(data);
            // this.registerSuccess=true;
       //  },
        // error=>
        // {
             //console.log("Somethign went wrong");
             //this.registerFailure=true;
        // }
    // )

 }
 pageName="Register";
 LegnthOfFirstName=25;
 LengthOfAge=2;
}
