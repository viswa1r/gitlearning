import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phoneformat'
})
export class PhoneformatPipe implements PipeTransform {

  transform(value: any, args?: any,args2?:boolean): any {
    console.log(value);
    if(args=="IN"){

      let result = value.substring(0,5)+"-"+value.substring(5,10);
      if(args2)
         return "+91- "+result;
        else
        return result;
    }
    if(args=="US"){
       let result = value.substring(0,3)+"-"+value.substring(3,6)+"-"+value.substring(6,10);
       if(args2)
          return "+1- "+result;
         else
         return result;
    }
    return value;
  }

}
