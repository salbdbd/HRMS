import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-holyday-calender',
  templateUrl: './holyday-calender.component.html',
  styleUrls: ['./holyday-calender.component.scss']
})
export class HolydayCalenderComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Holyday Calender";
  ngOnInit() {
    this.items = [1, 2, 3,4,5,6,7];
    this.update();
  }

}
