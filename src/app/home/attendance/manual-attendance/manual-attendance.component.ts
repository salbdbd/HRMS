import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-manual-attendance',
  templateUrl: './manual-attendance.component.html',
  styleUrls: ['./manual-attendance.component.scss']
})
export class ManualAttendanceComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Manual Attendance"
  ngOnInit() {
    this.items = ["a", "b", "c"];
    this.update();
  }

}
