import { Injectable } from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map'

@Injectable()
export class PostService {

  constructor(private http:Http) { 
    console.log("Post service intialized");
    
  }

  getPost(stocksymbol:String){
    return this.http.get('https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22'+stocksymbol+'%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=')
      .map(res => res.json());
  }
}
