import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { UserService } from './User.Service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RouterModule,NgFor],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  result:any={};
   constructor(private userservice:UserService) {
    
  }
  title = 'cloneapp';

  Details():void{
    this.userservice.GetUserDetails().subscribe(res=>{
    this.result=res;  
    }
      ,err=>{

      })
  }
}
