import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-signup',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {
  signupForm=new FormGroup({
    UserName:new FormControl(),
    Password:new FormControl(),
    Age:new FormControl()
  });

  Signup():void{
    console.warn(this.signupForm.value);
  }

}
