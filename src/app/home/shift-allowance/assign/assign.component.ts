import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-assign',
  templateUrl: './assign.component.html',
  styleUrls: ['./assign.component.scss']
})
export class AssignComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Assign Shift Allowance";
  ngOnInit() {
    this.items=[1,2];
    this.update();
  }

}
