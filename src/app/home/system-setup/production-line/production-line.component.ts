import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-production-line',
  templateUrl: './production-line.component.html',
  styleUrls: ['./production-line.component.scss']
})
export class ProductionLineComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Production Line";
  ngOnInit() {
    this.items = [];
  }

}
