import { Component } from '@angular/core';
import { ProductService } from '../Service/product.service';
import { NgFor } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { NavBarComponent } from '../nav-bar/nav-bar.component';

@Component({
  selector: 'app-show-product',
  standalone: true,
  imports: [NgFor, RouterModule,NavBarComponent],
  templateUrl: './show-product.component.html',
  styleUrl: './show-product.component.css'
})
export class ShowProductComponent {
  Message:any;
  details: any
  constructor(private productService: ProductService, public router: Router) {
    this.Message=sessionStorage.getItem("USR")
  
  this.loadProducts();
}

loadProducts(): void {
  this.productService.GetProduct().subscribe(res => {
    this.details = res;
    console.log('Products loaded:', res);
  }, err => {
    console.error('Error fetching products', err);
  });
}


  deleteProduct(d: any): void {
    this.productService.DeleteProduct(d).subscribe(res => { this.loadProducts();
      console.log('hyyyy')
    }, err => { });
  }
  
  editProduct(d: any): void {
    sessionStorage.setItem('id',d);
    this.router.navigate(['/UpdateProduct'])
  }
}