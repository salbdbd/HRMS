import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-unit',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./unit.component.scss']
})
export class UnitComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Unit";
  ngOnInit() {
  }

}
