import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: [
    './application.component.scss'
]
})
export class ApplicationComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Application for Attendance";
  inTime = {hour: 13, minute: 30, second: 30};
  outTime = {hour: 13, minute: 30, second: 30};
  ngOnInit() {
    this.items = [1,2,3,4,5,6];
    this.update();
  }

}
