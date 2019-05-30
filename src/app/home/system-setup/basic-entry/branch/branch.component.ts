
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-branch',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./branch.component.scss']
})
export class BranchComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Branch";
  ngOnInit() {
  }

}
