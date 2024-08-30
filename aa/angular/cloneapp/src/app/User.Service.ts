import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class UserService
{
    
    constructor(private httpclient:HttpClient)
    {
        
        
    }
    GetUserDetails():Observable<any>
    {
        return this.httpclient.get('https://jsonplaceholder.typicode.com/users')
    }
}