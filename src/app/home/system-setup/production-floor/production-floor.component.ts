import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-production-floor',
  templateUrl: './production-floor.component.html',
  styleUrls: ['./production-floor.component.scss']
})
export class ProductionFloorComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Production Floor";
  ngOnInit() {
    this.items = [];
  }

}
