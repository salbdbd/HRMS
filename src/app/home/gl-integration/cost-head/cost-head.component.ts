import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-cost-head',
  templateUrl: './cost-head.component.html',
  styleUrls: ['./cost-head.component.scss']
})
export class CostHeadComponent extends Pagination implements OnInit {

  constructor() { 
    super()
  }

  ngOnInit() {
    this.items=[];
    this.update
  }
}
