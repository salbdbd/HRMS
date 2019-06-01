import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-manual-payment',
  templateUrl: './manual-payment.component.html',
  styleUrls: ['./manual-payment.component.scss']
})
export class ManualPaymentComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Shift Allowance Payment Manual"
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
