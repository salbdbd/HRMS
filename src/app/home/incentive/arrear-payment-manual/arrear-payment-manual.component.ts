import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-arrear-payment-manual',
  templateUrl: './arrear-payment-manual.component.html',
  styleUrls: ['./arrear-payment-manual.component.scss']
})
export class ArrearPaymentManualComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Arrear Information";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
