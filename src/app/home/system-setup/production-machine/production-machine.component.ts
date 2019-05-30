import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-production-machine',
  templateUrl: './production-machine.component.html',
  styleUrls: ['./production-machine.component.scss']
})
export class ProductionMachineComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Production Machine";
  ngOnInit() {
    this.items = [];
  }

}
