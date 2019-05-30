
import { Component, OnInit, ViewChild } from '@angular/core';

import { DatatableComponent } from '@swimlane/ngx-datatable';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-department',
  templateUrl: '../basic-entry.component.html',
  styleUrls: [
    './department.component.scss'
  ]
})
export class DepartmentComponent extends Pagination implements OnInit {
  @ViewChild(DatatableComponent) table: DatatableComponent;

  title="Department";
  constructor() { 
    super();
  }

  ngOnInit() {
  }


  // perPage = 5;
  // filterVal = '';
  // currentPage = 1;
  // totalItems = 0;
  // sortBy = 'orderNo';
  // sortDesc = true;
  // searchKeys = ['name'];
  // items:any[]=[1,2,3];
  // tempItems:any[]=[];

  // get totalPages() {
  //   return Math.ceil(this.totalItems / this.perPage);
  // }
  
  // filterStatu(data) {
  //   const filter = this.filterVal.toLowerCase();
  //   const keys = ['statusText'];
  //   return !filter ?
  //     data.slice(0) :
  //     data.filter(d => {
  //       return Object.keys(d)
  //         .filter(k => keys.includes(k))
  //         .map(k => String(d[k]))
  //         .join('|')
  //         .toLowerCase()
  //         .indexOf(filter) !== -1 || !filter;
  //     });
  // }
  
  // filter(data) {
  //   const filter = this.filterVal.toLowerCase();
  //   return !filter ?
  //     data.slice(0) :
  //     data.filter(d => {
  //       return Object.keys(d)
  //         .filter(k => this.searchKeys.includes(k))
  //         .map(k => String(d[k]))
  //         .join('|')
  //         .toLowerCase()
  //         .indexOf(filter) !== -1 || !filter;
  //     });
  // }
  
  // sort(data) {
  //   data.sort((a: any, b: any) => {
  //     a = typeof (a[this.sortBy]) === 'string' ? a[this.sortBy].toUpperCase() : a[this.sortBy];
  //     b = typeof (b[this.sortBy]) === 'string' ? b[this.sortBy].toUpperCase() : b[this.sortBy];
  
  //     if (a < b) { return this.sortDesc ? 1 : -1; }
  //     if (a > b) { return this.sortDesc ? -1 : 1; }
  //     return 0;
  //   });
  // }
  // paginate(data) {
  //   const perPage = parseInt(String(this.perPage), 10);
  //   const offset = (this.currentPage - 1) * perPage;
  
  //   return data.slice(offset, offset + perPage);
  // }
  // changeStatus() {
  //   this.currentPage = 1;
  //   const data = this.filterStatu(this.items);
  //   this.totalItems = data.length;
  //   this.sort(data);
  //   this.tempItems = this.paginate(data);
  // }

  

}
