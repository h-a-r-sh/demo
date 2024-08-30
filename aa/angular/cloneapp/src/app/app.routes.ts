import { Routes } from '@angular/router';
import { SignupComponent } from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import { DashBoardComponent } from './dash-board/dash-board.component';

export const routes: Routes = [
    {path:"Signup",component:SignupComponent},
    {path:"Login",component:LoginComponent},
    {path:"DashBoard",component:DashBoardComponent}
];
