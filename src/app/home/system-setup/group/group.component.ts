import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-group',
  templateUrl: './group.component.html',
  styleUrls: ['./group.component.scss']
})
export class GroupComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Major/Group Name";
  ngOnInit() {
    this.items = [];
  }

}
