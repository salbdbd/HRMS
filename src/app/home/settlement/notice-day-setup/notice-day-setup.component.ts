import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-notice-day-setup',
  templateUrl: './notice-day-setup.component.html',
  styleUrls: ['./notice-day-setup.component.scss']
})
export class NoticeDaySetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Notice Day Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
