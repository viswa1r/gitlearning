import { Component, OnInit,Input,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-product-detail',
  templateUrl: './productdetail.component.html',
  styleUrls: ['./productdetail.component.css']
})
export class ProductdetailComponent implements OnInit {
  @Input()
  productDetails:any;

  @Output()
  chooseDetails:EventEmitter<any> = new EventEmitter<any>();

  public details={
    quantity:"1",
    discount:"2"
  };
  constructor() { }

  ngOnInit() {
  }
  selectData(){
    this.chooseDetails.emit(this.details);
  }
}
