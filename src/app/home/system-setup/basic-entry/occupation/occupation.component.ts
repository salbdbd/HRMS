import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-occupation',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./occupation.component.scss']
})
export class OccupationComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Occupation";
  ngOnInit() {
    this.items=[];
  }

}
