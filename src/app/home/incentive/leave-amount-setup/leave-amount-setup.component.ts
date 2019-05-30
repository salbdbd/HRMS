import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-leave-amount-setup',
  templateUrl: './leave-amount-setup.component.html',
  styleUrls: ['./leave-amount-setup.component.scss']
})
export class LeaveAmountSetupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Leave Encashment Amount Setup";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
