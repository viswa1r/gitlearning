import { Component, OnInit } from '@angular/core';
import {ProductService} from '../services/product.service';
@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
orderCount:number=0;
  constructor(private productSvc:ProductService) { }

  ngOnInit() {
    this.productSvc.getSelectedProducts()
    .subscribe(data=>{
      this.orderCount++;
    })
  }

}
