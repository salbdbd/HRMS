import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../../shared/paginate';

@Component({
  selector: 'app-result',
  templateUrl: '../basic-entry.component.html',
  styleUrls: ['./result.component.scss']
})
export class ResultComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
title="Result";
  ngOnInit() {
  }

}
