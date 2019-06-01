import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-approval',
  templateUrl: './leave-approval.component.html',
  styleUrls: ['./leave-approval.component.scss']
})
export class LeaveApprovalComponent extends Pagination implements OnInit {

  constructor() {
    super();
   }

  ngOnInit() {
    this.items = [1,2,3];
    this.update
  }

}
