import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-loan-deduct',
  templateUrl: './loan-deduct.component.html',
  styleUrls: ['./loan-deduct.component.scss']
})
export class LoanDeductComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Employee Loan Deduct";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
