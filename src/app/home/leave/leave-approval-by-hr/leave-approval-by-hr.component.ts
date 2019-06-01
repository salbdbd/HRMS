import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-approval-by-hr',
  templateUrl: './leave-approval-by-hr.component.html',
  styleUrls: ['./leave-approval-by-hr.component.scss']
})
export class LeaveApprovalByHrComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }

  ngOnInit() {
    this.items = [1,2,3,4,5,6,7,8,9,10,11,12,13];
    this.update();
    
  }

}
