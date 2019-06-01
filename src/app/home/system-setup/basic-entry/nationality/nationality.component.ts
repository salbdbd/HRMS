import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-nationality',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./nationality.component.scss']
})
export class NationalityComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Nationality";
  ngOnInit() {
  }

}
