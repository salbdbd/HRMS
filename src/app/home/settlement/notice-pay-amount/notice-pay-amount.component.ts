import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-notice-pay-amount',
  templateUrl: './notice-pay-amount.component.html',
  styleUrls: ['./notice-pay-amount.component.scss']
})
export class NoticePayAmountComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Notice Pay Amount Setup"
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
