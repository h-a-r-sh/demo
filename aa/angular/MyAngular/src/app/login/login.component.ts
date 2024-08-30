import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, RequiredValidator, Validators } from '@angular/forms';
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
export class LoginComponent implements OnInit
{
  message:any;
  LoginForm:FormGroup;
  constructor(private userservice:UserService,private router:Router,private fb: FormBuilder) {
    this.LoginForm = this.fb.group({
      username: ['', [Validators.required, Validators.minLength(3)]],
      password: ['', Validators.required]
    });
  }
  

 
  ngOnInit(): void {
    
  }

  LoginUser():void
  {
    this.userservice.UserAccountValidate(this.LoginForm.value).subscribe(res=>{
      console.log(res);
      if(res>0){
        let temp=this.LoginForm.value.username;
        sessionStorage.setItem("USR",temp);
        this.router.navigate(["/ProductDashBoard"]);
        this.message='Login Success';}
      else{
        this.message='Login not Success';
      }
    },
    err=>{

    })
  }
}
