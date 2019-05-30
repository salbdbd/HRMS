import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-institute',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./institute.component.scss']
})
export class InstituteComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Institute";
  ngOnInit() {
  }

}
