import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService 
{
  registerEndpoint:any='http://localhost:5083/api/User/CreateUser';
  LoginEndpoint:any='http://localhost:5083/api/User/Login';


  constructor(private httpclient:HttpClient)
  {
  }
  CreateUserAccount(Postobj:any):Observable<any>
  {
      return this.httpclient.post(this.registerEndpoint,Postobj);
  }
  UserAccountValidate(Postobj:any):Observable<any>
  {
    return this.httpclient.post(this.LoginEndpoint,Postobj)
  }
  GetSessionStorage():any{
    
    return sessionStorage.getItem('USR');
  }
  
}
