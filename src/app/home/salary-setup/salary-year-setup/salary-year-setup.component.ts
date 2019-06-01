import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-year-setup',
  templateUrl: './salary-year-setup.component.html',
  styleUrls: ['./salary-year-setup.component.scss']
})
export class SalaryYearSetupComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
