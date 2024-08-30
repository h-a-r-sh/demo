import { NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { Route, Router, RouterModule } from '@angular/router';
import { AppComponent } from '../app.component';
import { NavBarComponent } from '../nav-bar/nav-bar.component';

@Component({
  selector: 'app-dash-board',
  standalone: true,
  imports: [RouterModule,NgIf,NavBarComponent],
  templateUrl: './dash-board.component.html',
  styleUrl: './dash-board.component.css'
})
export class DashBoardComponent {
  Message:any;
  constructor(public router:Router){
    this.Message=sessionStorage.getItem("USR")
  }
  Logout():void{
    sessionStorage.removeItem('USR');
    
  }
}
