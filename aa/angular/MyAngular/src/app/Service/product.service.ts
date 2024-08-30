import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  GetProductEndPoint='http://localhost:5083/api/Product/GetProduct';
  GetProductEndPointById='http://localhost:5083/api/Product/GetProductById';
  AddProductEndPoint='http://localhost:5083/api/Product/AddProduct';
  UpdateProductEndPoint='http://localhost:5083/api/Product/ProductUpdated';
  DeleteProductEndPoint='http://localhost:5083/api/Product/DeleteProduct';

  constructor(private httpclient:HttpClient)
  {
  }
  GetProduct():Observable<any>
  {
      return this.httpclient.get(this.GetProductEndPoint);
  }
  GetProductById(id:any):Observable<any>
  {
      return this.httpclient.get(this.GetProductEndPointById+'/'+id);
  }
  AddProduct(obj:any):Observable<any>
  {
      return this.httpclient.post(this.AddProductEndPoint,obj);
  }
  DeleteProduct(obj:any):Observable<any>
  {
      return this.httpclient.post(this.DeleteProductEndPoint,obj);
  }
  UpdateProduct(obj:any):Observable<any>
  {
      return this.httpclient.put(this.UpdateProductEndPoint,obj);
  }
}
