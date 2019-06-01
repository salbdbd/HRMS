import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-assign-shift',
  templateUrl: './assign-shift.component.html',
  styleUrls: ['./assign-shift.component.scss']
})
export class AssignShiftComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Assign Shift";
  ngOnInit() {
    this.items = ["Item-1"];
    this.update();
  }

}
