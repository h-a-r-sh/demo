import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../Service/user.service';
import { Router } from '@angular/router';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule,NgIf],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent
{
  Message:any;
  constructor(private userservice:UserService,private router:Router)
  {

  }
  loginForm = new FormGroup({
    userName: new FormControl('',[Validators.required]),
    passWord: new FormControl('',[Validators.required, Validators.minLength(6)]),

  });

  loginUser():void
  {
    if (this.loginForm.invalid) {
      return;
    }
    // console.warn(this.loginForm.value);
    this.userservice.UserAccountValidate(this.loginForm.value).subscribe(res=>{
      console.log(res);
      if(res>0){
      // this.Message="Login Success";
      //At this point session needs to be maintained
      let temp:any=this.loginForm.value.userName;
      // console.log(temp);
      sessionStorage.setItem("USR",temp);
      this.router.navigate(["/ProductDashboard"]);
      }
      else{
        this.Message="Login Not Success";
      }
    },err=>{

    });

  }
  get f() {
    return this.loginForm.controls;
  }

}
