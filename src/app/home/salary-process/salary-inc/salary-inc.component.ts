import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-salary-inc',
  templateUrl: './salary-inc.component.html',
  styleUrls: ['./salary-inc.component.scss']
})
export class SalaryIncComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[1,2,3];
    this.update
  }

}
