import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-production-unit',
  templateUrl: './production-unit.component.html',
  styleUrls: ['./production-unit.component.scss']
})
export class ProductionUnitComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Production Unit"
  ngOnInit() {
    this.items = [];
  }

}
