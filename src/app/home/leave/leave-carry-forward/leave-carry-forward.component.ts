import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-carry-forward',
  templateUrl: './leave-carry-forward.component.html',
  styleUrls: ['./leave-carry-forward.component.scss']
})
export class LeaveCarryForwardComponent extends Pagination implements OnInit {

  constructor() { 
    super();
  }

  ngOnInit() {
    this.items=[];
    this.update
  }

}
