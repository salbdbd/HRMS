import { Component, OnInit } from '@angular/core';
import { expand } from 'rxjs/operators';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-salary-head',
  templateUrl: './salary-head.component.html',
  styleUrls: ['./salary-head.component.scss']
})
export class SalaryHeadComponent extends Pagination implements OnInit {

  constructor() {
    super()
   }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
