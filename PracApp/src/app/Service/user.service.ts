import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService
{
  registerEndPoint:any='http://localhost:5204/api/User/Signup';
  loginEndPoint:any='http://localhost:5204/api/User/Login';
  constructor(private httpclient:HttpClient)
  {

  }
  CreateUserAccount(Postobj:any):Observable<any>
  {
    return this.httpclient.post(this.registerEndPoint,Postobj);
  }

  UserAccountValidate(Postobjj:any):Observable<any>
  {
    return this.httpclient.post(this.loginEndPoint,Postobjj);
  }
  GetSessionStorage():any
  {
    return sessionStorage.getItem("USR");
  }
}
