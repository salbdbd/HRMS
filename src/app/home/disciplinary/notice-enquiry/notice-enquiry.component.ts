import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-notice-enquiry',
  templateUrl: './notice-enquiry.component.html',
  styleUrls: ['./notice-enquiry.component.scss']
})
export class NoticeEnquiryComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Notice of Enquiry";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
