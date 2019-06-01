import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-deduct',
  templateUrl: './salary-deduct.component.html',
  styleUrls: ['./salary-deduct.component.scss']
})
export class SalaryDeductComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Salary Deduct";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
