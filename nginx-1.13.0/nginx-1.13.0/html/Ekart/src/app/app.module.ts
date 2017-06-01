import { BrowserModule } from '@angular/platform-browser';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HttpModule } from '@angular/http';
import {RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import {HeaderComponent} from './header/header.component';
import {FooterComponent} from "./footer/footer.component";
import {RegisterComponent} from "./register/register.component";
import { ProductComponent } from './product/product.component';
import { HomeComponent } from './home/home.component';
//import { OrderComponent } from './order/order.component';

import {ProductService} from "./services/product.service";
import {RegisterService} from "./services/register.service";
import { LoginComponent } from './login/login.component';
import { ProductdetailComponent } from './productdetail/productdetail.component';
import { OrderComponent } from './order/order.component';
import { NumbersonlyDirective } from './directives/numbersonly.directive';
import { AlphabetsOnlyDirective } from './directives/alphabetsonly.directive';

import { DatepickerModule } from 'angular2-material-datepicker';
import { PhoneformatPipe } from './pipes/phoneformat.pipe';
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    RegisterComponent,
    ProductComponent,
    LoginComponent,
    ProductdetailComponent,
    OrderComponent,
    NumbersonlyDirective,
    AlphabetsOnlyDirective,
    PhoneformatPipe,
    HomeComponent
    //OrderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    DatepickerModule,
    NoopAnimationsModule,
    RouterModule.forRoot([{
      path: "home", component: HomeComponent
    },
      {
        path: "login", component: LoginComponent
      },
      { path: "register", component: RegisterComponent },
      { path: "products", component: ProductComponent,
    children:[
      {path:"product-detail/:name",component:ProductdetailComponent}
    ] },
      {path:'',redirectTo:'home',pathMatch:'full'},
      {path:'**',redirectTo:'home',pathMatch:'full'},])
  ],
  providers: [RegisterService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
