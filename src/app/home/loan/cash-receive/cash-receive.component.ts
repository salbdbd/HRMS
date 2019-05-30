import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-cash-receive',
  templateUrl: './cash-receive.component.html',
  styleUrls: ['./cash-receive.component.scss']
})
export class CashReceiveComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Loan Cash Payment Information";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
