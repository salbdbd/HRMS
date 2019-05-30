import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-assign-dept-gl',
  templateUrl: './assign-dept-gl.component.html',
  styleUrls: ['./assign-dept-gl.component.scss']
})
export class AssignDeptGlComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Assign Department GL";
  ngOnInit() {
    this.items = [];
  }

}
