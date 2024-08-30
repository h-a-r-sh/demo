import { Component, NgModule } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgModel, PatternValidator, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../Service/user.service';
import { Router } from '@angular/router';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule,NgIf],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent 
{
  message:any;
  constructor(private userService:UserService,private router:Router) {
    
  }
  RegisterForm = new FormGroup({
    Username: new FormControl('', [Validators.required, Validators.minLength(3)]),
    Password: new FormControl('', [Validators.required, Validators.minLength(6)]),
    Age: new FormControl('', [Validators.required, Validators.min(18)]),
    PhoneNumber: new FormControl('', [Validators.required, Validators.pattern('^[0-9]{10}$')])
  });

  
CreateUser():void
{
  // console.warn(this.RegisterForm.value);
  this.userService.CreateUserAccount(this.RegisterForm.value).subscribe(res=>{
    console.log(res);
    if(res>0){this.router.navigate(["/AccountLogin"]);}
    this.message='Record Added';
  },
  err=>{

  })
}

}
