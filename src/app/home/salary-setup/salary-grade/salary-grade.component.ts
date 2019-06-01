import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-grade',
  templateUrl: './salary-grade.component.html',
  styleUrls: ['./salary-grade.component.scss']
})
export class SalaryGradeComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
