import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HeaderComponent } from './Header/header.component';
import {UserComponent} from './User/user.component';
import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
 ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 

}
