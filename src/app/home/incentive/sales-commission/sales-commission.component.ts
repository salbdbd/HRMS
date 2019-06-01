import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-sales-commission',
  templateUrl: './sales-commission.component.html',
  styleUrls: ['./sales-commission.component.scss']
})
export class SalesCommissionComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Sales Commission Information";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
