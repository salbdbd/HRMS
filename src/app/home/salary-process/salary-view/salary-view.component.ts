import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-view',
  templateUrl: './salary-view.component.html',
  styleUrls: ['./salary-view.component.scss']
})
export class SalaryViewComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }
  ngOnInit() {
    this.items=[];
    this.update
  }

}
