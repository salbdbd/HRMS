import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-approve',
  templateUrl: './approve.component.html',
  styleUrls: ['./approve.component.scss']
})
export class ApproveComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Attendance Approve";
  ngOnInit() {
    this.items = [1,2,3,4,5,6];
    this.update();
  }

}
