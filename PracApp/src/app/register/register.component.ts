import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UserService } from '../Service/user.service';
import { Router } from '@angular/router';
import { NgFor, NgIf } from '@angular/common';


@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ReactiveFormsModule, NgFor,NgIf],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent
{
  Message:any;
  constructor(private userservice:UserService, private router:Router)
  {

  }
  //reactive approach means, we are desiging the structure then we create the form similar to a view model in MVC
  registerForm = new FormGroup({
    Username: new FormControl('',[Validators.required,Validators.minLength(3)]),
    Password: new FormControl('',[Validators.required,Validators.minLength(6)]),
    Age: new FormControl('',[Validators.required,Validators.min(18)]),
    PhoneNumber: new FormControl('',[Validators.required,Validators.pattern('^[0-9]{10}$')])
  });

  createUser():void
  {
    if(this.registerForm.invalid)
      {
        return;
      }
    // console.warn(this.registerForm.value);
    this.userservice.CreateUserAccount(this.registerForm.value).subscribe(res=>{
      console.log(res);
      // this.Message="Record is saved";
      this.router.navigate(['/Login'])
    },err=>{

    });
  }
  get f()
  {
    return this.registerForm.controls;
  }


}
