import {  NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule, RouterOutlet } from '@angular/router';
import { NavBarComponent } from './nav-bar/nav-bar.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RouterModule,NgIf,NavBarComponent],
  templateUrl: './app.component.html',
})
export class AppComponent {
  constructor(public router:Router) {
  }
  title = 'MyAngular';
  
  
}
