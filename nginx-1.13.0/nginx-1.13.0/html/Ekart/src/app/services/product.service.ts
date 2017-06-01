import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject'
@Injectable()
export class ProductService {

  constructor(private http: Http) {
  }
  cartItems = new Array<any>();
  selectedProduct: Subject<any> = new Subject<any>();
  products: any;
  addProductsToCart(data) {
    //this.cartItems.push(data);
    this.selectedProduct.next(data);
  }

  getSelectedProducts(): Observable<any> {
    return this.selectedProduct.asObservable();
  };

  getProductsFromWalmart(): Observable<Array<any>> {
    return this.http.get("wmapi/")
      .map(response => response.json().items);
      
  };
  searchProductsFromWalmart(data): Observable<Array<any>> {
    return this.http.get("wmapi/" + data)
      .map(response => response.json().items)
  };
}
