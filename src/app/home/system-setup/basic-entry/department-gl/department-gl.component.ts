import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-department-gl',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./department-gl.component.scss']
})
export class DepartmentGlComponent  extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Department GL";
  ngOnInit() {
  }

}
