import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, GuardResult, MaybeAsync, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { UserService } from '../Service/user.service';

@Injectable({
  providedIn: 'root'
})
export class ComponentGuard implements CanActivate
{
    constructor(private userservice:UserService, private router:Router)
    {

    }
    canActivate(): boolean
    {
        if(!this.userservice.GetSessionStorage())
        {
            this.router.navigate(["/Login"]);
            return false;
        }
        else{
            return true;
        }

    }

}
