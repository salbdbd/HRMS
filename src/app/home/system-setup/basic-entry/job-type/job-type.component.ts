import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-job-type',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./job-type.component.scss']
})
export class JobTypeComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Job Type";
  ngOnInit() {
    this.items = [];
  }

}
