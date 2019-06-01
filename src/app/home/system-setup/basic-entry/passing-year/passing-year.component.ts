import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-passing-year',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./passing-year.component.scss']
})
export class PassingYearComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Passing year";
  ngOnInit() {
  }

}
