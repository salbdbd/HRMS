import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-salary-period',
  templateUrl: './salary-period.component.html',
  styleUrls: ['./salary-period.component.scss']
})
export class SalaryPeriodComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
