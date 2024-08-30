import { Component } from '@angular/core';
import { ProductService } from '../Service/product.service';
import { Router, RouterModule } from '@angular/router';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';
import { NavBarComponent } from '../nav-bar/nav-bar.component';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [NgIf,ReactiveFormsModule,RouterModule,NavBarComponent],
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent {
  Message:any;
  constructor(private productService:ProductService,public router:Router)
  {
    this.Message=sessionStorage.getItem("USR")
  }
  addproductForm = new FormGroup({
    ProductName: new FormControl('',[Validators.required]),
    ProductDescription: new FormControl('',[Validators.required]),
    ProductPrice: new FormControl('',[Validators.required,Validators.min(0)])
  });

  addproduct():void
  {
    if(this.addproductForm.invalid)
    {
      return;
    }
    this.productService.AddProduct(this.addproductForm.value).subscribe(res=>{
      console.log(res);
      this.Message='Product Added'
      console.log(this.Message);
      this.router.navigate(['/ShowProduct']);
    }, err=>{
      console.log(err);
    })
  }
  
}
