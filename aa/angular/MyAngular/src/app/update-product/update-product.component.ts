import { Component, Input, OnInit } from '@angular/core';
import { ProductService } from '../Service/product.service';
import { Router, RouterModule } from '@angular/router';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';
import { NavBarComponent } from '../nav-bar/nav-bar.component';

@Component({
  selector: 'app-update-product',
  standalone: true,
  imports: [NgIf, ReactiveFormsModule, RouterModule, NavBarComponent],
  templateUrl: './update-product.component.html',
  styleUrl: './update-product.component.css'
})
export class UpdateProductComponent {
  details: any;
  Message: any;
  id:any
  
  updateproductForm = new FormGroup({
    id: new FormControl(),
    ProductName: new FormControl('', [Validators.required]),
    ProductDescription: new FormControl('', [Validators.required]),
    ProductPrice: new FormControl('', [Validators.required, Validators.min(0)])
  });

  constructor(private productService: ProductService, public router: Router) {
    this.id=sessionStorage.getItem('id');
    this.loadProducts(this.id);
    this.Message = sessionStorage.getItem("USR")
  }
  

  loadProducts(id :any): void {
    this.productService.GetProductById(id).subscribe(res => {
      this.details = res;
      console.log('Products loaded:', res);

      this.updateproductForm.patchValue({
        ProductName: this.details.productName,
        ProductDescription: this.details.productDescription,
        ProductPrice: this.details.productPrice
    })
  }, err => {
      console.error('Error fetching products', err);
    });
  }

  updateproduct(): void {
    if (this.updateproductForm.invalid) {
      return;
    }
    this.updateproductForm.value.id=Number(this.id),
    // console.log(this.updateproductForm.value)
    this.productService.UpdateProduct(this.updateproductForm.value).subscribe(res => {
      console.log(res);
      this.Message = 'Product Updated'
      console.log(this.Message);
      this.router.navigate(['/ShowProduct']);
    }, err => {
      console.log(err);
    })
  }

}