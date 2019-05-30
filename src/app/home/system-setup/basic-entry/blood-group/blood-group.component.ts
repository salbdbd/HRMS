
import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-blood-group',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./blood-group.component.scss']
})
export class BloodGroupComponent extends Pagination implements OnInit {

  constructor() { 
    super();
  }
title="Blood Group";
  ngOnInit() {
  }

}
