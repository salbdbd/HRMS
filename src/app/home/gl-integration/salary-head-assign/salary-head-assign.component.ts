import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-head-assign',
  templateUrl: './salary-head-assign.component.html',
  styleUrls: ['./salary-head-assign.component.scss']
})
export class SalaryHeadAssignComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }
}
