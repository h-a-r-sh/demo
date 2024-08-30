import { NgIf } from '@angular/common';
import { Component, Input } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [NgIf,RouterModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css'
})
export class NavBarComponent {
  @Input() user: any;
  constructor(public router:Router) {
  }
  Logout():void{
    this.user=null;
    console.log('hello');
    sessionStorage.removeItem('USR');
    
  }
}
