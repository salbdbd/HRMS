import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-gender',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./gender.component.scss']
})
export class GenderComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Gender";
  ngOnInit() {
  }

}
