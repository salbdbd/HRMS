import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-emp-info',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./emp-info.component.scss']
})
export class EmpInfoComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Basic Info Entry";
 
  ngOnInit() {
    this.items = [1,2,3,4,5,6,7,8,9,10];
    this.update();
    this.filterVal;
  }

}
