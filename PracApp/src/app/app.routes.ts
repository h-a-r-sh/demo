import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ComponentGuard } from './Security/ComponentGuard';

export const routes: Routes = [
    {path:'Signup',component:RegisterComponent},
    {path:'Login',component:LoginComponent},
    {path:'ProductDashboard',component:DashboardComponent,canActivate:[ComponentGuard]}

];
