import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-location',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./location.component.scss']
})
export class LocationComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Location";
  ngOnInit() {
    this.items = [1,2,3,4,5,6,7,8,9,0];
   
  }

}
