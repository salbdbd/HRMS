import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-log-history',
  templateUrl: './log-history.component.html',
  styleUrls: ['./log-history.component.scss']
})
export class LogHistoryComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Log History";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
