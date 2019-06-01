import { Pagination } from './../../../shared/paginate';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-driver-allowance',
  templateUrl: './driver-allowance.component.html',
  styleUrls: ['./driver-allowance.component.scss']
})
export class DriverAllowanceComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
 title="Driver Allowance";
  ngOnInit() {
    this.items = [];
    this.update();
  }

}
