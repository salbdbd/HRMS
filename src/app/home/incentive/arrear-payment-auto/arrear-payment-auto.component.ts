import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-arrear-payment-auto',
  templateUrl: './arrear-payment-auto.component.html',
  styleUrls: ['./arrear-payment-auto.component.scss']
})
export class ArrearPaymentAutoComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Arrear Information";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
