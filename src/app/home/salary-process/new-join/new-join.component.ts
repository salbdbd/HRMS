import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-new-join',
  templateUrl: './new-join.component.html',
  styleUrls: ['./new-join.component.scss']
})
export class NewJoinComponent extends Pagination implements OnInit {

  constructor() {
    super()
  }

  ngOnInit() {
    this.items = [];
    this.update
  }

}
