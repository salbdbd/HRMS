import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-leave-type-setup',
  templateUrl: './leave-type-setup.component.html',
  styleUrls: ['./leave-type-setup.component.scss']
})
export class LeaveTypeSetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Leave Encashment Leave Type Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
