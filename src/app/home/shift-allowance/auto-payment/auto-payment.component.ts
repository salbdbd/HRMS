import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-auto-payment',
  templateUrl: './auto-payment.component.html',
  styleUrls: ['./auto-payment.component.scss']
})
export class AutoPaymentComponent extends Pagination implements OnInit {

  constructor() {
    super();
   }
   title="Shift Allowance Payment Auto";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
