import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-block-salary-process',
  templateUrl: './block-salary-process.component.html',
  styleUrls: ['./block-salary-process.component.scss']
})
export class BlockSalaryProcessComponent extends Pagination implements OnInit {

  constructor() {
    super()
  }

  ngOnInit() {
    this.items = [];
    this.update
  }
}
