import { Component,OnInit } from '@angular/core';
import { ProductService } from "../services/product.service";
@Component({
    selector: "custom-header",
    templateUrl: "./header.component.html"
})
export class HeaderComponent implements OnInit {
    constructor(private productSvc:ProductService){
        this.cartItems= new Array<any>();
    }

    ngOnInit(){
            this.productSvc.getSelectedProducts()
            .subscribe((data)=>{
                console.log(data);
                this.cartItems.push(data);
            });
    }
    BrandName = "E-Kart";
    viewName ="Home";
    cartItems:Array<any>
    loadRegister() {
        this.viewName="Register";
    }

    loadHome() {
        this.viewName="Home";
    }
    loadProducts(){
        this.viewName="Products";
    }
    loadCart(){
        this.viewName="Cart";
    }

}
