import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-leave-payment',
  templateUrl: './leave-payment.component.html',
  styleUrls: ['./leave-payment.component.scss']
})
export class LeavePaymentComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Substitute Leave Payment";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
