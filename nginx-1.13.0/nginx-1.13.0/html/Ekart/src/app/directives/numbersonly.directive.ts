import { Directive,HostListener,ElementRef,Input } from '@angular/core';

@Directive({
  selector: '[appNumbersonly]'
})
export class NumbersonlyDirective {
  @Input() maxLength=10;
//inject ElementRef to the directive
  constructor(private el:ElementRef) {
    //this.el.nativeElement.style.backgroundColor="red";
   }
   @HostListener('keypress',["$event"]) onKeyPress(evt){
     var regex = new RegExp(/^\d+$/);
     var isNumber = regex.test(evt.key);
     var totalLength = this.el.nativeElement.value.length;
     if(totalLength>=this.maxLength || !isNumber){
       evt.preventDefault();
     }


   }
}
