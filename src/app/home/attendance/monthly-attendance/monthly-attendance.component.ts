import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-monthly-attendance',
  templateUrl: './monthly-attendance.component.html',
  styleUrls: ['./monthly-attendance.component.scss']
})
export class MonthlyAttendanceComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Attendance";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
