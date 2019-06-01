import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-loan-info',
  templateUrl: './loan-info.component.html',
  styleUrls: ['./loan-info.component.scss']
})
export class LoanInfoComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Loan Information"
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
