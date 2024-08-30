import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { DashBoardComponent } from './dash-board/dash-board.component';
import { ComponentGuard } from './Security/ComponentGuard';
import { AddProductComponent } from './add-product/add-product.component';
import { ShowProductComponent } from './show-product/show-product.component';
import { DeleteProductComponent } from './delete-product/delete-product.component';
import { UpdateProductComponent } from './update-product/update-product.component';

export const routes: Routes = [
    {path:'AccountCreate',component:RegisterComponent},
    {path:'AccountLogin',component:LoginComponent},
    {path:'ProductDashBoard',component:DashBoardComponent,canActivate:[ComponentGuard]},
    {path:'AddProduct',component:AddProductComponent},
    {path:'ShowProduct',component:ShowProductComponent},
    {path:'DeleteProduct',component:DeleteProductComponent},
    {path:'UpdateProduct',component:UpdateProductComponent}
    
];
