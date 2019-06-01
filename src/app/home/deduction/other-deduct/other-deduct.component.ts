import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-other-deduct',
  templateUrl: './other-deduct.component.html',
  styleUrls: ['./other-deduct.component.scss']
})
export class OtherDeductComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Employee Other Deduct";
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
