import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-division',
  templateUrl: './division.component.html',
  styleUrls: ['./division.component.scss']
})
export class DivisionComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Division";
  ngOnInit() {
    this.items = [];
  }

}
