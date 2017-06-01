import { Component } from '@angular/core';
import { Product } from './product';
import { Products } from "./product.data";
import { ProductService } from "../services/product.service";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {

  constructor(private productSvc: ProductService) {
    //this.products = Products;
    //this.getProducts();

  }
  search: String;
  products: Array<Product>;
  orders: Array<Product> = new Array<Product>();
  selectedProduct: any;
  addItemToCart(data) {
    if (data) {
      let details = {
        description:data.shortDescription,
        thumbnailImage:data.thumbnailImage,
        modelNumber: data.modelNumber
      };

      this.selectedProduct = details;
    }

    this.productSvc.addProductsToCart(data);
  }

  productChoosed(data){
    console.log(data);
  }
  // getProducts() {
  //     this.productSvc.getProductsFromWalmart()
  //         .subscribe(
  //         data => {
  //             console.log(data)
  //             this.products=data;
  //            // this.products = data.items;
  //         },
  //         err => {
  //             console.log(err)
  //         }
  //         );

  // };
  SearchProducts() {
    this.productSvc.searchProductsFromWalmart(this.search)
      .subscribe(
      data => {
        //console.log(data)
        this.products = data;
        this.products.forEach(item=>{
          item.deliveryDate=this.randomDate(1,15);
        });
        console.log(this.products);

        // this.products = data.items;
      },
      err => {
        console.log(err)
      }
      );
  }
   randomDate(start, end) {
  var date = new Date(+start + Math.random() * (end - start));
  return date;
}
}
