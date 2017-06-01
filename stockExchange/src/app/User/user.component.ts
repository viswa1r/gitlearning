import {Component} from '@angular/core';
import {PostService} from '../Services/services.component'

@Component({
selector:"custom-search",
templateUrl:"./user.component.html",
providers: [PostService]
})

export class UserComponent{
    postService1:PostService;
    BrandName = "E-Kart";
    viewName:String;
    quotes = {
        symbol:String,
        companyName:String,
        PreviousClose:String,
        open:String,
        volume:String,
        daysRange:String,
        LastTradePriceOnly:String
    }

    portfolioInfo={}

 
    constructor(private postService:PostService){  
        this.postService1=postService    
    }

    stockSym:String;

    getStockQuote(){

        //console.log("STOCKSYSBOL:"+ this.stockSym);
        this.postService1.getPost(this.stockSym).subscribe(posts => {
            console.log(posts);
           this.quotes.symbol = posts.query.results.quote.symbol;
           this.quotes.companyName = posts.query.results.quote.Name;
           this.quotes.PreviousClose = posts.query.results.quote.PreviousClose;
           this.quotes.open = posts.query.results.quote.Open;
           this.quotes.volume = posts.query.results.quote.Volume;
           this.quotes.daysRange = posts.query.results.quote.DaysRange;
           this.quotes.LastTradePriceOnly = posts.query.results.quote.LastTradePriceOnly;

        })
        this.viewName="searchResults"
    }

    addStock(){
        
    }
    
}
