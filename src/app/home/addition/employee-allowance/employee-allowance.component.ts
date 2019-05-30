import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-employee-allowance',
  templateUrl: './employee-allowance.component.html',
  styleUrls: ['./employee-allowance.component.scss']
})
export class EmployeeAllowanceComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Allowance";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
