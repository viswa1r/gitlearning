import {Injectable} from '@angular/core';
//the below code is need to make a http call.
import {Http} from'@angular/http';

//Observables
import {Observable} from 'rxjs/Observable';
import 'rxjs'; 

@Injectable()
export class RegisterService{
    //Injecting http as a dependency to the Register Service.
    constructor(private http :Http){

    }
    registerUser(user){
        console.log(user);
     };
    //Create a observable method.
    //registerUser(data):Observable<any>{
       // return this.http.post("api/register",data)
        //.map(res=>res.json());
   // }
}