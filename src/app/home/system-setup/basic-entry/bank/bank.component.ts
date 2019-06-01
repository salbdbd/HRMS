
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-bank',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./bank.component.scss']
})
export class BankComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Bank";
  ngOnInit() {
    this.items = [1,2,3,4,5,6,7,8,9,0];
    this.items;
    this.perPage = 5;
    this.searchKeys=[];
    this.sortBy="";
    this.sortDesc=false;
    this.totalItems;
    this.totalPages;
    this.currentPage = 1;
    this.update();
    this.filter(this.items);
    this.paginate(this.items);
    this.currentPage = 1;
    this.filterStatu(this.items);
    this.sort(this.items);
  }

}
