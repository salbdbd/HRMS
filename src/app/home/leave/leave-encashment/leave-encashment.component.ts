import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-encashment',
  templateUrl: './leave-encashment.component.html',
  styleUrls: ['./leave-encashment.component.scss']
})
export class LeaveEncashmentComponent extends Pagination implements OnInit {

  constructor() { 
    super();
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
